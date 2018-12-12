Public Class Form1

    Private Sub getBUTTON_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles getBUTTON.Click
        On Error GoTo getbent
        Dim adoConn As New ADODB.Connection
        Dim strdsn As String
        Dim sqlstring1 As String
        Dim sqlstring2 As String
        Dim objtocreate As String : objtocreate = ""
        Dim objtype As String
        Dim devaddress As String
        Dim lastdevaddress As String
        Dim wherestring As String : wherestring = ""
        Dim iocount As Integer : iocount = 0
        Dim querylist As ListView
        Dim createlist As ListView
        Dim objectlabel As Label
        Dim iptrefobjtype As String : iptrefobjtype = ""
        Dim objrefval As objectLIST
        '---------------------------------------------------------------------------------------------------------------------

        srcobjVIEW.Items.Clear()

        newevtlVIEW.Items.Clear()

        totalrefLABEL.Text = 0
        oldevtlVIEW.Items.Clear()
        srcobjVIEW.MultiSelect = True
        newevtlVIEW.Visible = False
        oldevtlVIEW.Visible = True

        newobjLABEL.Visible = False
        oldobjLABEL.Visible = True
        ProgressBar1.Value = 0

        clearresults()

        '---------------------------------------------------------------------------------------------------------------------
        'enable progress bar when button is clicked
        ProgressBar1.Visible = True

        '---------------------------------------------------------------------------------------------------------------------
        'set up ODBC DSN text
        strdsn = dsnTEXTBOX.Text
        If strdsn = "" Then
            strdsn = "Delta Network"
        End If

        '---------------------------------------------------------------------------------------------------------------------
        'connect to the ODBC DSN
        adoConn = New ADODB.Connection
        adoConn.ConnectionString = "DSN=" & strdsn & ";"
        adoConn.Open()

        '---------------------------------------------------------------------------------------------------------------------
        'check whether user wants to create EV or TL objects
        If eventRAD.Checked Then
            objtocreate = "EV"
            trendRAD.Checked = False
        ElseIf trendRAD.Checked Then
            objtocreate = "TL"
            eventRAD.Checked = False
        End If

        '---------------------------------------------------------------------------------------------------------------------
        'build up SQL Strings for generating existing object list
        objrefval = objCOMBO.Items(objCOMBO.SelectedIndex)
        objtype = objrefval.Name
        iptrefobjtype = CStr(objrefval.ItemData)
        devaddress = devTEXTBOX.Text
        lastdevaddress = lastdevTEXT.Text




        If rangeCHECK.Checked = True Then
            wherestring = "DEV_ID >= " & devaddress & " AND DEV_ID <= " & lastdevaddress
        Else
            wherestring = "DEV_ID = " & devaddress
        End If


        sqlstring1 = "SELECT ObjRef, Name, Value, DEV_ID, instance FROM OBJECT_BAC_" & objtype & " WHERE" & " " & wherestring
        sqlstring2 = "SELECT ObjRef, Name, inputref, DEV_ID, instance From OBJECT_BAC_" & objtocreate & " WHERE" & " " & wherestring & " AND InputRefObjectType = " & iptrefobjtype
        '---------------------------------------------------------------------------------------------------------------------
        'set up the listview object to dump the object result set
        querylist = srcobjVIEW
        createlist = oldevtlVIEW
        '---------------------------------------------------------------------------------------------------------------------
        'call subroutine to execute SQL that returns all reference objects and existing TL/EV objects
        objectlabel = totobjsLABEL
        runOBJQUERY(adoConn, sqlstring2, createlist, objectlabel) 'grab existing TL/EV objects
        objectlabel = totalrefLABEL
        runOBJQUERY(adoConn, sqlstring1, querylist, objectlabel) 'grab reference objects


        '---------------------------------------------------------------------------------------------------------------------
        'close the result set and ODBC connection

        adoConn.Close()
        adoConn = Nothing
        Exit Sub
getbent:
        MessageBox.Show("Data Error Detected. Please ensure that you have entered a valid object reference, valid Device Address and correct ODBC DSN", "ODBC Reference Error")
        dsnTEXTBOX.Text = "Delta Network"
        adoConn.Close()
        adoConn = Nothing
        ProgressBar1.Value = 0
    End Sub


    '---------------------------------------------------------------------------------------------------------------------
    'Subroutine to handle the create object button. The user selects the desired input reference object(s) and clicks the Create Button
    'makes calls to the createobj, queryobj subroutines as well as the queryTLEV function
    Private Sub createBUTTON_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles createBUTTON.Click
        On Error GoTo getbent
        Dim adoConn As New ADODB.Connection
        Dim strdsn As String
        Dim sqlstring2 As String
        Dim sqlstring3 As String
        Dim sqlstring4 As String
        Dim objtocreate As String : objtocreate = ""
        Dim objtype As String
        Dim devaddress As String
        Dim lastdevaddress As String
        Dim wherestring As String : wherestring = ""
        Dim iocount As Integer : iocount = 0
        Dim evtlcount As Integer : evtlcount = 0
        Dim i As Integer : i = 0
        Dim evtltext As String : evtltext = ""
        Dim createinstance As String : createinstance = ""
        Dim j As Integer : j = 1
        Dim refobj As String : refobj = ""
        Dim refname As String : refname = ""
        Dim loopval As Integer : loopval = 0
        Dim numobjcreated As Integer : numobjcreated = 0
        Dim logintervalval As Integer : logintervalval = 0
        Dim bufferSize As Integer : bufferSize = 2688
        Dim startTime As Integer : startTime = 0
        Dim algval As String : algval = ""
        Dim lowlimitval As String : lowlimitval = ""
        Dim hilimitval As String = ""
        Dim analogevflag As Boolean : analogevflag = False
        Dim counter As Integer : counter = 0
        Dim monobjref As String : monobjref = ""
        Dim evtlList As ListView
        Dim objectlabel As Label
        Dim objrefval As objectLIST
        Dim refdev As String
        Dim iptrefobjtype As String
        Dim ipref As Integer : ipref = 0
        Dim newobjectlist(100, 2) As String
        Dim instance As String

        '---------------------------------------------------------------------------------------------------------------------
        'initialize boxes and labels

        newevtlVIEW.Items.Clear()
        bufferSize = txtSamples.Text
        newevtlVIEW.Visible = True
        oldevtlVIEW.Visible = False
        ProgressBar1.Value = 0

        '---------------------------------------------------------------------------------------------------------------------
        'set up ODBC DSN text
        strdsn = dsnTEXTBOX.Text
        If strdsn = "" Then
            strdsn = "Delta Network"
        End If

        '---------------------------------------------------------------------------------------------------------------------
        'connect to the ODBC DSN
        adoConn = New ADODB.Connection
        adoConn.ConnectionString = "DSN=" & strdsn & ";"
        adoConn.Open()


        '---------------------------------------------------------------------------------------------------------------------
        'build up SQL Strings for generating existing object list

        objrefval = objCOMBO.Items(objCOMBO.SelectedIndex)
        objtype = objrefval.Name
        iptrefobjtype = CStr(objrefval.ItemData)
        devaddress = devTEXTBOX.Text
        lastdevaddress = lastdevTEXT.Text

        If rangeCHECK.Checked = True Then
            wherestring = "DEV_ID >= " & devaddress & " AND DEV_ID <= " & lastdevaddress
        Else
            wherestring = "DEV_ID = " & devaddress
        End If
        'count i/o objects
        iocount = totalrefLABEL.Text

        '---------------------------------------------------------------------------------------------------------------------
        'check whether user wants to create EV or TL objects
        If eventRAD.Checked Then
            objtocreate = "EV"
            trendRAD.Checked = False
        ElseIf trendRAD.Checked Then
            objtocreate = "TL"
            eventRAD.Checked = False
        End If

        evtlList = oldevtlVIEW
        objectlabel = totobjsLABEL




        '---------------------------------------------------------------------------------------------------------------------
        'build object creation string based on selected object typue - EV or TL
        If objtocreate = "EV" Then
            If objCOMBO.Text = "BV" Or objCOMBO.Text = "BI" Or
                                        objCOMBO.Text = "BO" Or
                                        objCOMBO.Text = "MI" Or
                                        objCOMBO.Text = "MV" Then  'determine whether to create a COS or OOR EV
                algval = "COS"
                'evtltext = "EV (ParametersType, DEV_ID, Instance, Name, InputRef) Values('" & algval & "', " & devaddress & ", "
                evtltext = "EV (ParametersType, DEV_ID, Instance, Name, InputRef) Values('" & algval & "'"
                analogevflag = False
            Else
                algval = "Out of Range"
                evtltext = "EV (ParametersType, DEV_ID, Instance, Name, InputRef, ParametersOutofRangeLowlimit, ParametersOutofRangeHiLimit) Values('" & algval & "'"
                analogevflag = True
            End If

        ElseIf objtocreate = "TL" Then
            If objCOMBO.Text = "BV" Or objCOMBO.Text = "BI" Or objCOMBO.Text = "BO" Then  'determine whether to create a COV or Polling Trend Log
                logintervalval = 0
            Else
                logintervalval = sampleInterval.Text
            End If
            ' evtltext = "TL (LogInterval, DEV_ID, Instance, Name, InputRef) Values(" & logintervalval & ", " & devaddress & ", "
            evtltext = "TL (LogInterval, BufferSize, DEV_ID, Instance, Name, InputRef) Values(" & logintervalval
            analogevflag = False
        End If

        '---------------------------------------------------------------------------------------------------------------------
        'loop to generate insert sql script that will create the objects - also calls the create object subroutine
        If iocount > 0 Then
            ProgressBar1.Increment(1)
            loopval = (srcobjVIEW.SelectedItems.Count() - 1) 'get the number of selected items in the reference object ListView. "-1" used because listview index starts at 0
            newobjLABEL.Visible = True
            oldobjLABEL.Visible = False

            For i = 0 To loopval 'loop through the reference object listview to grab the obj ref and obj name
                ProgressBar1.Increment(+1)
                refobj = srcobjVIEW.SelectedItems(i).Text
                refname = srcobjVIEW.SelectedItems(i).SubItems(1).Text
                refdev = srcobjVIEW.SelectedItems(i).SubItems(3).Text
                instance = srcobjVIEW.SelectedItems(i).SubItems(4).Text
                'If AV is being logged, use the same instance ID
                If (objCOMBO.Text = "AV" And objtocreate = "TL" And chkmatchAVInstance.Checked) Then
                    createinstance = instance
                Else
                    sqlstring2 = "SELECT Instance, Name, InputRef FROM OBJECT_BAC_" & objtocreate & " " & " WHERE " & "DEV_ID = " & refdev

                    createinstance = CStr(queryTLEV(adoConn, sqlstring2) + 1)
                End If
                


                If analogevflag = True Then 'special condition to set up EV parameters for out of range EV objects
                    lowlimitval = srcobjVIEW.SelectedItems(i).SubItems(2).Text - 5
                    hilimitval = srcobjVIEW.SelectedItems(i).SubItems(2).Text + 5
                    sqlstring3 = "INSERT INTO OBJECT_BAC_" & evtltext & ", " & refdev & ", " & createinstance & ", " & "'" & refname & " " & objtocreate & createinstance & "', " & "'" & refobj & ".value', " & lowlimitval & ", " & hilimitval & ")"
                Else
                    If (objtocreate = "TL") Then
                        sqlstring3 = "INSERT INTO OBJECT_BAC_" & evtltext & ", " & bufferSize & " , " & refdev & ", " & createinstance & ", " & "'" & refname & " " & objtocreate & "', " & "'" & refobj & ".value')"
                    Else
                        sqlstring3 = "INSERT INTO OBJECT_BAC_" & evtltext & " , " & refdev & ", " & createinstance & ", " & "'" & refname & " Alarm" & "', " & "'" & refobj & ".value')"
                    End If
                End If

                TextBox1.Text = sqlstring3 'write to a hidden text field for debugging
                sqlstring4 = "SELECT ObjRef, Name, InputRef FROM OBJECT_BAC_" & objtocreate & " " & " WHERE " & "DEV_ID = " & refdev & " AND Instance = " & createinstance
                ipref = tstobjref(oldevtlVIEW, refobj)
                If ipref = 0 Then
                    createOBJs(adoConn, sqlstring3) 'call the create object subroutine
                    newobjectlist = newobjquery(adoConn, sqlstring4)
                    newevtlVIEW.Items.Add(newobjectlist(0, 0))
                    newevtlVIEW.Items(j - 1).SubItems.Add(newobjectlist(0, 1))
                    newevtlVIEW.Items(j - 1).SubItems.Add(newobjectlist(0, 2))
                    j = j + 1
                End If


            Next

            ProgressBar1.Value = 100
            numobjcreated = (j - 1)
            totobjsLABEL.Text = numobjcreated
            createdobjLABEL.Text = numobjcreated & " " & objtocreate & " objects created"
            '---------old code----------
            'If srcobjVIEW.SelectedItems.Count() > 0 Then 'only run the TL query if objects were created
            ' evtlList = newevtlVIEW
            ' sqlstring3 = "Select ObjRef, Name, InputRef, DEV_ID FROM Object_BAC_" & objtocreate & " Where " & wherestring & " AND InputRefObjectType = " & iptrefobjtype
            '  objectlabel = totobjsLABEL
            ' runOBJQUERY(adoConn, sqlstring3, evtlList, objectlabel)
            'indnewitems(newevtlVIEW, newobjectlist, numobjcreated)
            'Else
            'MessageBox.Show("No Objects Created - Please select an object reference from the list", "No Items Selected")
            'End If
            '---------------------------

            If srcobjVIEW.SelectedItems.Count() <= 0 Then 'present message to the user if no items were created/selected
                MessageBox.Show("No Objects Created - Please select an object reference from the list", "No Items Selected")
            End If

            srcobjVIEW.SelectedItems.Clear()
        Else
            refobj = ""
            refname = ""

        End If

        '---------------------------------------------------------------------------------------------------------------------
        'disable the Create Object button until the network is queried again
        createBUTTON.Enabled = False

        '---------------------------------------------------------------------------------------------------------------------
        'close the result set and ODBC connection
        adoConn.Close()
        adoConn = Nothing
        Exit Sub
getbent:
        MessageBox.Show("Data Error Detected. Please ensure that you have enter a valid object reference, valid Device Address and correct ODBC DSN", "ODBC Reference Error")
        dsnTEXTBOX.Text = "Delta Network"
        adoConn.Close()
        adoConn = Nothing
        ProgressBar1.Value = 0
    End Sub

    '---------------------------------------------------------------------------------------------------------------------
    'Subroutine to close the form
    Private Sub closeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeButton.Click
        Close()
    End Sub

    '---------------------------------------------------------------------------------------------------------------------
    'Subroutine to handle the clear results push button

    Private Sub clearBUTTON_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearBUTTON.Click
        '---------------------------------------------------------------------------------------------------------------------
        'clear out the list box, reset the object counter and the progress bar when the reset results button is pressed
        clearresults()
       
    End Sub

    '---------------------------------------------------------------------------------------------------------------------
    'Subroutine to clear listviews, labels and text boxes

    Public Sub clearresults()
        '---------------------------------------------------------------------------------------------------------------------
        'clear out the list box, reset the object counter and the progress bar when the reset results button is pressed

        srcobjVIEW.Items.Clear()
        oldevtlVIEW.Items.Clear()
        newevtlVIEW.Items.Clear()
        objCOMBO.Enabled = True
        totobjsLABEL.Text = 0
        totalrefLABEL.Text = 0
        ProgressBar1.Value = 0
        ProgressBar1.Visible = False
    End Sub

    '---------------------------------------------------------------------------------------------------------------------
    'Subroutine to display help and info message
    Private Sub hpBUTTON_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hpBUTTON.Click
        Dim messagestring1 As String
        Dim messagestring2 As String
        Dim messagestring3 As String
        messagestring1 = "This is a utility that creates EV and TL objects for each I/O and Variable object detected in a controller database. "
        messagestring2 = "Enter the ODBC DSN (find this from the ODBC Administrator). You can leave this blank for the default 'Delta Network'. "
        messagestring3 = "Enter the Device's Address then select the object type and click the 'Get Object List' button."
        MessageBox.Show(messagestring1 & messagestring2 & messagestring3, "Create EVs and TLs by Andy Beaveridge, Copyright Delta Controls 2011")
    End Sub

    '---------------------------------------------------------------------------------------------------------------------
    'Subroutine to query  the controller database for object references to be used as inputrefs for EVs and TLs

    Public Sub runOBJQUERY(ByRef adoConn As ADODB.Connection, ByVal sqlstring As String, ByVal inListView As ListView, ByVal intxtLABEL As Label)
        Dim adoRS As New ADODB.Recordset

        Dim inputrefmod As String
        Dim reccount As Integer : reccount = 0
        Dim i As Integer : i = 0

        '---------------------------------------------------------------------------------------------------------------------
        'open the ODBC connection

        adoRS.ActiveConnection = adoConn

        '---------------------------------------------------------------------------------------------------------------------
        'send the SQL query to the ODBC connection
        adoRS.Open(sqlstring)

        totalrefLABEL.Text = reccount


        '---------------------------------------------------------------------------------------------------------------------
        'write the display the ODBC query result set in the List box - increment the progress bar
        Do While Not adoRS.EOF
            ProgressBar1.Increment(+1)
            inListView.Items.Add(adoRS.Fields(0).Value)
            inListView.Items(i).SubItems.Add(adoRS.Fields(1).Value)
            inputrefmod = Replace(adoRS.Fields(2).Value, "BAC.", "")
            inListView.Items(i).SubItems.Add(inputrefmod)
            inListView.Items(i).SubItems.Add(adoRS.Fields(3).Value)
            inListView.Items(i).SubItems.Add(adoRS.Fields(4).Value)
            adoRS.MoveNext()
            i = i + 1
        Loop
        intxtLABEL.Text = i
        ProgressBar1.Value = 100

        'disable the create object button if there are no objects to create TLs or EVs for
        If i > 0 Then
            createBUTTON.Enabled = True
        Else
            createBUTTON.Enabled = False
        End If

        '--------------------------------------------------------------------
        'close the result set
        adoRS.Close()
        adoRS = Nothing
        Threading.Thread.Sleep(500)
    End Sub


    '------------------------------------------------------------------------------------
    'subroutine to create TLs or EVs based on the user's selection

    Public Sub createOBJs(ByRef adoConn As ADODB.Connection, ByVal sqlstring As String)
        Dim adoRS As New ADODB.Recordset
        Dim adocmd As New ADODB.Command

        '---------------------------------------------------------------------------------------------------------------------
        'open the ODBC connection
        adocmd.ActiveConnection = adoConn
        ' adoRS.ActiveConnection = adoConn

        '---------------------------------------------------------------------------------------------------------------------
        'send the SQL query to the ODBC connection and create the objects
        'adoRS.Open(sqlstring)
        adocmd.CommandText = sqlstring
        adocmd.Execute()
        ' adoRS.Close()
        ' adoRS = Nothing
        adocmd = Nothing

    End Sub

    '---------------------------------------------------------------------------------------------------------------------
    'function to query  the controller database for newly created objects

    Public Function newobjquery(ByRef adoConn As ADODB.Connection, ByVal insqlstring As String) As String(,)
        Dim adoRS As New ADODB.Recordset
        Dim objresults(0, 2) As String
        Dim inputrefmod As String
        Dim i As Integer : i = 0

        '---------------------------------------------------------------------------------------------------------------------
        'open the ODBC connection

        adoRS.ActiveConnection = adoConn

        '---------------------------------------------------------------------------------------------------------------------
        'send the SQL query to the ODBC connection
        adoRS.Open(insqlstring)


        '---------------------------------------------------------------------------------------------------------------------
        'write the display the ODBC query result set in the List box - increment the progress bar
        Do While Not adoRS.EOF
            objresults(0, 0) = (adoRS.Fields(0).Value)
            objresults(0, 1) = (adoRS.Fields(1).Value)
            inputrefmod = Replace(adoRS.Fields(2).Value, "BAC.", "")
            objresults(0, 2) = (inputrefmod)
            adoRS.MoveNext()
        Loop




        '--------------------------------------------------------------------
        'close the result set
        adoRS.Close()
        adoRS = Nothing
        Threading.Thread.Sleep(100)
        Return objresults
    End Function

    '------------------------------------------------------------------------------------
    'Function to grab the highest instance of a TL or EV in a controller
    'ensures that we won't try to duplicate an object instance
    Public Function queryTLEV(ByRef INadoConn As ADODB.Connection, ByVal INsqlstring As String) As Integer

        Dim adoRS As New ADODB.Recordset
        Dim i As Integer : i = 0
        Dim querynum As Integer : querynum = 0
        Dim results(20) As Integer

        '---------------------------------------------------------------------------------------------------------------------
        'open the ODBC connection

        adoRS.ActiveConnection = INadoConn

        '---------------------------------------------------------------------------------------------------------------------
        'send the SQL query to the ODBC connection
        adoRS.Open(INsqlstring)


        Do While Not adoRS.EOF
            ReDim Preserve results(i)
            results(i) = adoRS.Fields(0).Value
            adoRS.MoveNext()
            i = i + 1
        Loop

        'find the last instance of the object and save the value for when we go to create new objects
        If i = 0 Then
            querynum = 0
        Else
            ' maxinst = tlevBOX.Items.Item(i - 1)
            querynum = results.Max
        End If

        'totalTL.Text = maxinst
        adoRS.Close()
        adoRS = Nothing
        Threading.Thread.Sleep(100)


        Return querynum

    End Function

    '------------------------------------------------------------------------------------------------------------------------------------
    'Function to test whether or not a TL/EV already has the selected input reference
    Public Function tstobjref(ByRef inlstVIEW As ListView, ByVal strref As String) As Integer
        Dim counter As Integer : counter = 0
        Dim stringpos As Integer : stringpos = 0
        Dim objexists As Integer : objexists = 0
        For counter = 0 To (inlstVIEW.Items.Count - 1)
            stringpos = InStr(inlstVIEW.Items(counter).SubItems(2).Text, strref)
            objexists += stringpos
        Next

        Return objexists
    End Function

    Public Sub indnewitems(ByRef inlistVIEW As ListView, ByVal objlistarray(,) As String, ByVal numofobjs As Integer)
        Dim counter As Integer : counter = 0

        For counter = 0 To (numofobjs - 1)

            inlistVIEW.Items.Add(objlistarray(counter, 0))
            inlistVIEW.Items(counter).SubItems.Add(objlistarray(counter, 1))
            inlistVIEW.Items(counter).SubItems.Add(objlistarray(counter, 2))
            counter += 1

        Next
    End Sub
    '------------------------------------------------------------------------------------------------------------------------------------
    'Subroutine to enable or disable the device range fields based on the checkbox value

    Private Sub rangeCHECK_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rangeCHECK.CheckedChanged
        If rangeCHECK.Checked = True Then
            lastdevTEXT.Visible = True
            lastdevLABEL.Visible = True
            firstdevLABEL.Visible = True
            singledevLABEL.Visible = False
        Else
            lastdevTEXT.Visible = False
            lastdevLABEL.Visible = False
            firstdevLABEL.Visible = False
            singledevLABEL.Visible = True
        End If
    End Sub

    '------------------------------------------------------------------------------------------------------------------------------------
    'Subroutine to add BACnet objects to select from a drop down list. 
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With objCOMBO
            .Items.Add(New objectLIST("AI", 260))
            .Items.Add(New objectLIST("AO", 257))
            .Items.Add(New objectLIST("BI", 261))
            .Items.Add(New objectLIST("BO", 258))
            .Items.Add(New objectLIST("AV", 264))
            .Items.Add(New objectLIST("PI", 263))
            .Items.Add(New objectLIST("BV", 265))
            .Items.Add(New objectLIST("BV", 266))
            .Items.Add(New objectLIST("MI", 262))
            .Items.Add(New objectLIST("CO", 274))
            .SelectedIndex = 0 'Set first item as selected item.
            'Add more object refs and id numbers as required
            setCOMBO()
        End With
    End Sub

    Private Sub objCOMBO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles objCOMBO.SelectedIndexChanged
        setCOMBO()
    End Sub

    Public Sub setCOMBO()
        Dim objList As objectLIST

        ' Get the selected item.
        objList = objCOMBO.Items(objCOMBO.SelectedIndex)

    End Sub

    
End Class

'--------------------------------------------------------------------------------------------------
'Class to map dictionary object type values into a property of the objectLIST combo box
'This will be used to specify which TL or EV objects will  be displayed based on object reference
'code snippets are from http://social.msdn.microsoft.com/Forums/en/winforms/thread/3e24d8b9-6841-43b3-89c8-c93d13fd0b33
Public Class objectLIST
    Private sOBJREF As String

    Private iID As Integer

    ' Default empty constructor.
    Public Sub New()
        sOBJREF = ""
        iID = 0
    End Sub

    Public Sub New(ByVal Name As String, ByVal ID As Integer)
        sOBJREF = Name
        iID = ID
    End Sub

    Public Property Name() As String
        Get
            Return sOBJREF
        End Get
        Set(ByVal sValue As String)
            sOBJREF = sValue
        End Set
    End Property

    ' This is the property that holds the extra data.
    Public Property ItemData() As Int32
        Get
            Return iID
        End Get
        Set(ByVal iValue As Int32)
            iID = iValue
        End Set
    End Property

    ' This is neccessary because the ListBox and ComboBox rely
    ' on this method when determining the text to display.
    Public Overrides Function ToString() As String
        Return sOBJREF
    End Function

End Class


