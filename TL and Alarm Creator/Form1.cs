using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace TL_and_Alarm_Creator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }


        private void rangeCHECK_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (rangeCHECK.Checked == true)
            {
                lastdevTEXT.Visible = true;
                lastdevLABEL.Visible = true;
                firstdevLABEL.Visible = true;
                singledevLABEL.Visible = false;
                lblRemoteDevice.Visible = false;
                txtRemoteDevice.Visible = false;
            }
            else
            {
                lastdevTEXT.Visible = false;
                lastdevLABEL.Visible = false;
                firstdevLABEL.Visible = false;
                singledevLABEL.Visible = true;
            }
        }

        //=======================================================
        //Service provided by Telerik (www.telerik.com)
        //Conversion powered by NRefactory.
        //Twitter: @telerik
        //Facebook: facebook.com/telerik
        //=======================================================

        //---------------------------------------------------------------------------------------------------------------------
        //Subroutine to close the form
        private void closeButton_Click(System.Object sender, System.EventArgs e)
        {
            Close();
        }

        //---------------------------------------------------------------------------------------------------------------------
        //Subroutine to handle the clear results push button

        private void clearBUTTON_Click(System.Object sender, System.EventArgs e)
        {
            //---------------------------------------------------------------------------------------------------------------------
            //clear out the list box, reset the object counter and the progress bar when the reset results button is pressed
            clearresults();

        }

        //---------------------------------------------------------------------------------------------------------------------
        //Subroutine to clear listviews, labels and text boxes

        public void clearresults()
        {
            //---------------------------------------------------------------------------------------------------------------------
            //clear out the list box, reset the object counter and the progress bar when the reset results button is pressed

            srcobjVIEW.Items.Clear();
            oldevtlVIEW.Items.Clear();
            newevtlVIEW.Items.Clear();
            objCOMBO.Enabled = true;
            totobjsLABEL.Text = "0";
            totalrefLABEL.Text = "0";
            ProgressBar1.Value = 0;
            ProgressBar1.Visible = false;
        }

        //---------------------------------------------------------------------------------------------------------------------
        //Subroutine to display help and info message
        private void hpBUTTON_Click(System.Object sender, System.EventArgs e)
        {
            string messagestring1 = null;
            string messagestring2 = null;
            string messagestring3 = null;
            messagestring1 = "This is a utility that creates EV and TL objects for each I/O and Variable object detected in a controller database. ";
            messagestring2 = "Enter the ODBC DSN (find this from the ODBC Administrator). You can leave this blank for the default 'Delta Network'. ";
            messagestring3 = "Enter the Device's Address then select the object type and click the 'Get Object List' button.";
            MessageBox.Show(messagestring1 + messagestring2 + messagestring3, "Create EVs and TLs by Andy Beaveridge, Copyright Delta Controls 2011");
        }

        //---------------------------------------------------------------------------------------------------------------------
        //Subroutine to query  the controller database for object references to be used as inputrefs for EVs and TLs

        public void runOBJQUERY(ref ADODB.Connection adoConn, string sqlstring, ListView inListView, Label intxtLABEL)
        {
            ADODB.Recordset adoRS = new ADODB.Recordset();

            string inputrefmod = null;
            int reccount = 0;
            reccount = 0;
            int i = 0;
            i = 0;
            try
            {
            //---------------------------------------------------------------------------------------------------------------------
            //open the ODBC connection

            adoRS.ActiveConnection = adoConn;

            //---------------------------------------------------------------------------------------------------------------------
            //send the SQL query to the ODBC connection
            adoRS.Open(sqlstring);

            totalrefLABEL.Text = reccount.ToString();


            //---------------------------------------------------------------------------------------------------------------------
            //write the display the ODBC query result set in the List box - increment the progress bar
            while (!adoRS.EOF)
            {
                ProgressBar1.Increment(+1);
                inListView.Items.Add((string) adoRS.Fields[0].Value);
                inListView.Items[i].SubItems.Add((string) adoRS.Fields[1].Value);
                inputrefmod =  adoRS.Fields[2].Value.ToString().Replace("BAC.","");
                inListView.Items[i].SubItems.Add(inputrefmod);
                inListView.Items[i].SubItems.Add(adoRS.Fields[3].Value.ToString());
                inListView.Items[i].SubItems.Add(adoRS.Fields[4].Value.ToString());
                adoRS.MoveNext();
                i = i + 1;
            }
            intxtLABEL.Text = i.ToString();
            ProgressBar1.Value = 100;

            //disable the create object button if there are no objects to create TLs or EVs for
            if (i > 0)
            {
                createBUTTON.Enabled = true;
            }
            else
            {
                createBUTTON.Enabled = false;
            }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            //--------------------------------------------------------------------
            //close the result set
            adoRS.Close();
            adoRS = null;
            System.Threading.Thread.Sleep(500);
        }


        //------------------------------------------------------------------------------------
        //subroutine to create TLs or EVs based on the user's selection

        public void createOBJs(ref ADODB.Connection adoConn, string sqlstring)
        {
            ADODB.Recordset adoRS = new ADODB.Recordset();
            ADODB.Command adocmd = new ADODB.Command();
            object objRecAff;
            //---------------------------------------------------------------------------------------------------------------------
            //open the ODBC connection
            adocmd.ActiveConnection = adoConn;
            // adoRS.ActiveConnection = adoConn

            //---------------------------------------------------------------------------------------------------------------------
            //send the SQL query to the ODBC connection and create the objects
            //adoRS.Open(sqlstring)
            adocmd.CommandText = sqlstring;
            adocmd.Execute(out objRecAff);
            // adoRS.Close()
            // adoRS = Nothing
            adocmd = null;

        }

        //---------------------------------------------------------------------------------------------------------------------
        //function to query  the controller database for newly created objects

        public string[,] newobjquery(ref ADODB.Connection adoConn, string insqlstring)
        {
            ADODB.Recordset adoRS = new ADODB.Recordset();
            string[,] objresults = new string[1, 3];
            string inputrefmod = null;
            int i = 0;
            i = 0;

            //---------------------------------------------------------------------------------------------------------------------
            //open the ODBC connection

            adoRS.ActiveConnection = adoConn;

            //---------------------------------------------------------------------------------------------------------------------
            //send the SQL query to the ODBC connection
            adoRS.Open(insqlstring);


            //---------------------------------------------------------------------------------------------------------------------
            //write the display the ODBC query result set in the List box - increment the progress bar
            while (!adoRS.EOF)
            {
                objresults[0, 0] = (string) (adoRS.Fields[0].Value);
                objresults[0, 1] = (string) (adoRS.Fields[1].Value);
                inputrefmod = adoRS.Fields[2].Value.ToString().Replace("BAC.", "");
                objresults[0, 2] = (inputrefmod);
                adoRS.MoveNext();
            }




            //--------------------------------------------------------------------
            //close the result set
            adoRS.Close();
            adoRS = null;
            System.Threading.Thread.Sleep(100);
            return objresults;
        }

        //------------------------------------------------------------------------------------
        //Function to grab the highest instance of a TL or EV in a controller
        //ensures that we won't try to duplicate an object instance
        public int queryTLEV(ref ADODB.Connection INadoConn, string INsqlstring)
        {

            ADODB.Recordset adoRS = new ADODB.Recordset();
            int i = 0;
            i = 0;
            int querynum = 0;
            querynum = 0;
            int[] results = new int[21];

            //---------------------------------------------------------------------------------------------------------------------
            //open the ODBC connection

            adoRS.ActiveConnection = INadoConn;

            //---------------------------------------------------------------------------------------------------------------------
            //send the SQL query to the ODBC connection
            adoRS.Open(INsqlstring);


            while (!adoRS.EOF)
            {
                Array.Resize(ref results, i + 1);
                results[i] = (int) adoRS.Fields[0].Value;
                adoRS.MoveNext();
                i = i + 1;
            }

            //find the last instance of the object and save the value for when we go to create new objects
            if (i == 0)
            {
                querynum = 0;
            }
            else
            {
                // maxinst = tlevBOX.Items.Item(i - 1)
                querynum = results.Max();
            }

            //totalTL.Text = maxinst
            adoRS.Close();
            adoRS = null;
            Thread.Sleep(100);


            return querynum;

        }

        //------------------------------------------------------------------------------------------------------------------------------------
        //Function to test whether or not a TL/EV already has the selected input reference
        public int tstobjref(ref ListView inlstVIEW, string strref)
        {
            int counter = 0;
            counter = 0;
            int stringpos = 0;
            stringpos = 0;
            int objexists = 0;
            objexists = 0;
            for (counter = 0; counter <= (inlstVIEW.Items.Count - 1); counter++)
            {
                stringpos = inlstVIEW.Items[counter].SubItems[2].Text.IndexOf(strref,0);
                if (stringpos != -1)
                {
                    objexists += stringpos;
                }
            }

            return objexists;
        }

        public void indnewitems(ref ListView inlistVIEW, string[,] objlistarray, int numofobjs)
        {
            int counter = 0;
            counter = 0;


            for (
                counter = 0; counter <= (numofobjs - 1); counter++)
            {
                inlistVIEW.Items.Add(objlistarray[counter, 0]);
                inlistVIEW.Items[counter].SubItems.Add(objlistarray[counter, 1]);
                inlistVIEW.Items[counter].SubItems.Add(objlistarray[counter, 2]);
                counter += 1;

            }
        }
        //------------------------------------------------------------------------------------------------------------------------------------
        //Subroutine to enable or disable the device range fields based on the checkbox value

        //------------------------------------------------------------------------------------------------------------------------------------
        //Subroutine to add BACnet objects to select from a drop down list. 
        private void Form1_Load(System.Object sender, System.EventArgs e)
        {
            var _with1 = objCOMBO;
            _with1.Items.Add(new objectLIST("AI", 260));
            _with1.Items.Add(new objectLIST("AO", 257));
            _with1.Items.Add(new objectLIST("BI", 261));
            _with1.Items.Add(new objectLIST("BO", 258));
            _with1.Items.Add(new objectLIST("AV", 264));
            _with1.Items.Add(new objectLIST("PI", 263));
            _with1.Items.Add(new objectLIST("BV", 265));
            _with1.Items.Add(new objectLIST("MV", 266));
            _with1.Items.Add(new objectLIST("MI", 262));
            _with1.Items.Add(new objectLIST("CO", 274));
            _with1.Items.Add(new objectLIST("SCH", 269));
            _with1.SelectedIndex = 0;
            //Set first item as selected item.
            //Add more object refs and id numbers as required
            setCOMBO();
        }

        private void objCOMBO_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            setCOMBO();
        }

        public void setCOMBO()
        {
            objectLIST objList = null;

            // Get the selected item.
            objList = (objectLIST) objCOMBO.Items[objCOMBO.SelectedIndex];

        }

        private void getButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(devTEXTBOX.Text))
            {
                MessageBox.Show("Please enter a device instance");
                return;
            }
            ADODB.Connection adoConn = new ADODB.Connection();
            string strdsn = null;
            string sqlstring1 = null;
            string sqlstring2 = null;
            string objtocreate = null;
            objtocreate = "";
            string objtype = null;
            string devaddress = null;
            string lastdevaddress = null;
            string wherestring = null;
            wherestring = "";
            int iocount = 0;
            iocount = 0;
            ListView querylist = default(ListView);
            ListView createlist = default(ListView);
            Label objectlabel = default(Label);
            string iptrefobjtype = null;
            iptrefobjtype = "";
            objectLIST objrefval = default(objectLIST);
            try
            {
                //---------------------------------------------------------------------------------------------------------------------
                //initialization

                srcobjVIEW.Items.Clear();

                newevtlVIEW.Items.Clear();

                totalrefLABEL.Text = "0";
                oldevtlVIEW.Items.Clear();
                srcobjVIEW.MultiSelect = true;
                newevtlVIEW.Visible = false;
                oldevtlVIEW.Visible = true;

                newobjLABEL.Visible = false;
                oldobjLABEL.Visible = true;
                ProgressBar1.Value = 0;

                clearresults();

                //---------------------------------------------------------------------------------------------------------------------
                //enable progress bar when button is clicked
                ProgressBar1.Visible = true;

                //---------------------------------------------------------------------------------------------------------------------
                //set up ODBC DSN text
                strdsn = dsnTEXTBOX.Text;
                if (string.IsNullOrEmpty(strdsn))
                {
                    strdsn = "Delta Network";
                }

                //---------------------------------------------------------------------------------------------------------------------
                //connect to the ODBC DSN
                adoConn = new ADODB.Connection();
                adoConn.ConnectionString = "DSN=" + strdsn + ";";
                adoConn.Open();

                //---------------------------------------------------------------------------------------------------------------------
                //check whether user wants to create EV or TL objects
                if (eventRAD.Checked)
                {
                    objtocreate = "EV";
                    trendRAD.Checked = false;
                }
                else if (trendRAD.Checked)
                {
                    objtocreate = "TL";
                    eventRAD.Checked = false;
                }

                //---------------------------------------------------------------------------------------------------------------------
                //build up SQL Strings for generating existing object list
                objrefval = (objectLIST) objCOMBO.Items[objCOMBO.SelectedIndex];
                objtype = objrefval.Name;
                iptrefobjtype = Convert.ToString(objrefval.ItemData);
                if (chkIsRemote.Checked)
                {
                    devaddress = txtRemoteDevice.Text;
                }
                else
                {
                    devaddress = devTEXTBOX.Text;
                }
                lastdevaddress = lastdevTEXT.Text;




                if (rangeCHECK.Checked == true)
                {
                    wherestring = "DEV_ID >= " + devaddress + " AND DEV_ID <= " + lastdevaddress;
                }
                else
                {
                    wherestring = "DEV_ID = " + devaddress;
                }

                if (objtype == "PI")
                {
                    sqlstring1 = "SELECT ObjRef, Name, TotalPulses, DEV_ID, instance FROM OBJECT_BAC_" + objtype + " WHERE" + " " +
                                 wherestring;
                }
                else
                {
                    sqlstring1 = "SELECT ObjRef, Name, Value, DEV_ID, instance FROM OBJECT_BAC_" + objtype + " WHERE" + " " +
                                 wherestring;
                }
                
                sqlstring2 = "SELECT ObjRef, Name, inputref, DEV_ID, instance From OBJECT_BAC_" + objtocreate + " WHERE" +
                             " " + wherestring + " AND InputRefObjectType = " + iptrefobjtype;
                //---------------------------------------------------------------------------------------------------------------------
                //set up the listview object to dump the object result set
                querylist = srcobjVIEW;
                createlist = oldevtlVIEW;
                //---------------------------------------------------------------------------------------------------------------------
                //call subroutine to execute SQL that returns all reference objects and existing TL/EV objects
                objectlabel = totobjsLABEL;
                runOBJQUERY(ref adoConn, sqlstring2, createlist, objectlabel);
                //grab existing TL/EV objects
                objectlabel = totalrefLABEL;
                runOBJQUERY(ref adoConn, sqlstring1, querylist, objectlabel);
                //grab reference objects


                //---------------------------------------------------------------------------------------------------------------------
                //close the result set and ODBC connection

                adoConn.Close();
                adoConn = null;
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Error Detected. Please ensure that you have entered a valid object reference, valid Device Address and correct ODBC DSN", "ODBC Reference Error");
                dsnTEXTBOX.Text = "Delta Network";
                adoConn.Close();
                adoConn = null;
                ProgressBar1.Value = 0;
            }
            
            //=======================================================
            //Service provided by Telerik (www.telerik.com)
            //Conversion powered by NRefactory.
            //Twitter: @telerik
            //Facebook: facebook.com/telerik
            //=======================================================

        }

        private void createButton_Click(object sender, EventArgs e)
        {

            ADODB.Connection adoConn = new ADODB.Connection();
            string strdsn = null;
            string sqlstring2 = null;
            string sqlstring3 = null;
            string sqlstring4 = null;
            string objtocreate = null;
            objtocreate = "";
            string objtype = null;
            string devaddress = null;
            string lastdevaddress = null;
            //string wherestring = null;
            //wherestring = "";
            int iocount = 0;
            iocount = 0;
            int evtlcount = 0;
            evtlcount = 0;
            int i = 0;
            i = 0;
            string evtltext = null;
            evtltext = "";
            string createinstance = null;
            createinstance = "";
            int j = 0;
            j = 1;
            string refobj = null;
            refobj = "";
            string refname = null;
            refname = "";
            int loopval = 0;
            loopval = 0;
            int numobjcreated = 0;
            numobjcreated = 0;
            int logintervalval = 0;
            logintervalval = 0;
            int bufferSize = 0;
            bufferSize = 2688;
            int startTime = 0;
            startTime = 0;
            string algval = null;
            algval = "";
            string lowlimitval = null;
            lowlimitval = "";
            string hilimitval = "";
            bool analogevflag = false;
            analogevflag = false;
            int counter = 0;
            counter = 0;
            string monobjref = null;
            monobjref = "";
            ListView evtlList = default(ListView);
            Label objectlabel = default(Label);
            objectLIST objrefval = default(objectLIST);
            string refdev = null;
            string iptrefobjtype = null;
            int ipref = 0;
            ipref = 0;
            string[,] newobjectlist = new string[101, 3];
            string instance = null;

            try
            {

            


            //---------------------------------------------------------------------------------------------------------------------
            //initialize boxes and labels

            newevtlVIEW.Items.Clear();
            bufferSize = Convert.ToInt32(txtSamples.Text);
            newevtlVIEW.Visible = true;
            oldevtlVIEW.Visible = false;
            ProgressBar1.Value = 0;

            //---------------------------------------------------------------------------------------------------------------------
            //set up ODBC DSN text
            strdsn = dsnTEXTBOX.Text;
            if (string.IsNullOrEmpty(strdsn))
            {
                strdsn = "Delta Network";
            }

            //---------------------------------------------------------------------------------------------------------------------
            //connect to the ODBC DSN
            adoConn = new ADODB.Connection();
            adoConn.ConnectionString = "DSN=" + strdsn + ";";
            adoConn.Open();


            //---------------------------------------------------------------------------------------------------------------------
            //build up SQL Strings for generating existing object list

            objrefval = (objectLIST) objCOMBO.Items[objCOMBO.SelectedIndex];
            objtype = objrefval.Name;
            iptrefobjtype = Convert.ToString(objrefval.ItemData);
            devaddress = devTEXTBOX.Text;
            lastdevaddress = lastdevTEXT.Text;

            if (rangeCHECK.Checked == true)
            {
                //wherestring = "DEV_ID >= " + devaddress + " AND DEV_ID <= " + lastdevaddress;
            }
            else
            {
                //wherestring = "DEV_ID = " + devaddress;
            }
            //count i/o objects
            iocount = Convert.ToInt32(totalrefLABEL.Text);

            //---------------------------------------------------------------------------------------------------------------------
            //check whether user wants to create EV or TL objects
            if (eventRAD.Checked)
            {
                objtocreate = "EV";
                trendRAD.Checked = false;
            }
            else if (trendRAD.Checked)
            {
                objtocreate = "TL";
                eventRAD.Checked = false;
            }

            evtlList = oldevtlVIEW;
            objectlabel = totobjsLABEL;




            //---------------------------------------------------------------------------------------------------------------------
            //build object creation string based on selected object typue - EV or TL
            if (objtocreate == "EV")
            {
                //determine whether to create a COS or OOR EV
                if (objCOMBO.Text == "BV" | objCOMBO.Text == "BI" | objCOMBO.Text == "BO" | objCOMBO.Text == "MI" | objCOMBO.Text == "MV" | objCOMBO.Text == "SCH")
                {
                    algval = "COS";
                    //evtltext = "EV (ParametersType, DEV_ID, Instance, Name, InputRef) Values('" & algval & "', " & devaddress & ", "
                    evtltext = "EV (ParametersType, DEV_ID, Instance, Name, InputRef) Values('" + algval + "'";
                    analogevflag = false;
                }
                else
                {
                    algval = "Out of Range";
                    evtltext = "EV (ParametersType, DEV_ID, Instance, Name, InputRef, ParametersOutofRangeLowlimit, ParametersOutofRangeHiLimit) Values('" + algval + "'";
                    analogevflag = true;
                }

            }
            else if (objtocreate == "TL")
            {
                

                //determine whether to create a COV or Polling Trend Log
                if (objCOMBO.Text == "MV" | objCOMBO.Text == "BV" | objCOMBO.Text == "BI" | objCOMBO.Text == "BO" | objCOMBO.Text == "SCH")
                {
                    logintervalval = 0;
                }
                else
                {
                    logintervalval = Convert.ToInt32(sampleInterval.Text);
                }
                // evtltext = "TL (LogInterval, DEV_ID, Instance, Name, InputRef) Values(" & logintervalval & ", " & devaddress & ", "
                evtltext = "TL (LogInterval, BufferSize, DEV_ID, Instance, Name, InputRef) Values(" + logintervalval;
                analogevflag = false;
            }
                string objectProperty = "value";
                if (objCOMBO.Text == "PI")
                    objectProperty = "TotalPulses";
                //---------------------------------------------------------------------------------------------------------------------
                //loop to generate insert sql script that will create the objects - also calls the create object subroutine
                if (iocount > 0)
            {
                ProgressBar1.Increment(1);
                loopval = (srcobjVIEW.SelectedItems.Count - 1);
                //get the number of selected items in the reference object ListView. "-1" used because listview index starts at 0
                newobjLABEL.Visible = true;
                oldobjLABEL.Visible = false;

                //loop through the reference object listview to grab the obj ref and obj name
                for (i = 0; i <= loopval; i++)
                {
                    ProgressBar1.Increment(+1);
                    refobj = srcobjVIEW.SelectedItems[i].Text;
                    refname = srcobjVIEW.SelectedItems[i].SubItems[1].Text;
                    refdev = chkIsRemote.Checked? devTEXTBOX.Text: srcobjVIEW.SelectedItems[i].SubItems[3].Text;
                    instance = srcobjVIEW.SelectedItems[i].SubItems[4].Text;
                    //If AV is being logged, use the same instance ID
                    if ((objCOMBO.Text == "AV" & objtocreate == "TL" & chkmatchAVInstance.Checked))
                    {
                        createinstance = instance;
                    }
                    else
                    {
                        sqlstring2 = "SELECT Instance, Name, InputRef FROM OBJECT_BAC_" + objtocreate + " " + " WHERE " + "DEV_ID = " + refdev;

                        createinstance = Convert.ToString(queryTLEV(ref adoConn, sqlstring2) + 1);
                    }

                    //If we're looking at a remote device, set the refobj to the remote device
                    if (chkIsRemote.Checked)
                    {
                        //refdev = devTEXTBOX.Text;
                    }

                    //special condition to set up EV parameters for out of range EV objects
                    if (analogevflag == true)
                    {
                        lowlimitval = (Double.Parse(srcobjVIEW.SelectedItems[i].SubItems[2].Text) - 5).ToString();
                        hilimitval = (Double.Parse(srcobjVIEW.SelectedItems[i].SubItems[2].Text) + 5).ToString();
                        sqlstring3 = "INSERT INTO OBJECT_BAC_" + evtltext + ", " + refdev + ", " + createinstance + ", " + "'" + refname + " " + objtocreate + createinstance + "', " + "'" + refobj + ".value', " + lowlimitval + ", " + hilimitval + ")";
                    }
                    else
                    {
                        if ((objtocreate == "TL"))
                        {
                            sqlstring3 = "INSERT INTO OBJECT_BAC_" + evtltext + ", " + bufferSize + " , " + refdev + ", " + createinstance + ", " + "'" + refname + " " + objtocreate + "', " + "'" + refobj + "."+objectProperty+"')";
                        }
                        else
                        {
                            sqlstring3 = "INSERT INTO OBJECT_BAC_" + evtltext + " , " + refdev + ", " + createinstance + ", " + "'" + refname + " Alarm" + "', " + "'" + refobj + ".value')";
                        }
                    }

                    TextBox1.Text = sqlstring3;
                    //write to a hidden text field for debugging
                    sqlstring4 = "SELECT ObjRef, Name, InputRef FROM OBJECT_BAC_" + objtocreate + " " + " WHERE " + "DEV_ID = " + refdev + " AND Instance = " + createinstance;
                    ipref = tstobjref(ref oldevtlVIEW, refobj);
                    if (ipref == 0)
                    {
                        createOBJs(ref adoConn, sqlstring3);
                        //call the create object subroutine
                        newobjectlist = newobjquery(ref adoConn, sqlstring4);
                        newevtlVIEW.Items.Add(newobjectlist[0, 0]);
                        newevtlVIEW.Items[j - 1].SubItems.Add(newobjectlist[0, 1]);
                        newevtlVIEW.Items[j - 1].SubItems.Add(newobjectlist[0, 2]);
                        j = j + 1;
                    }


                }

                ProgressBar1.Value = 100;
                numobjcreated = (j - 1);
                totobjsLABEL.Text = numobjcreated.ToString();
                createdobjLABEL.Text = numobjcreated + " " + objtocreate + " objects created";
                //---------old code----------
                //If srcobjVIEW.SelectedItems.Count() > 0 Then 'only run the TL query if objects were created
                // evtlList = newevtlVIEW
                // sqlstring3 = "Select ObjRef, Name, InputRef, DEV_ID FROM Object_BAC_" & objtocreate & " Where " & wherestring & " AND InputRefObjectType = " & iptrefobjtype
                //  objectlabel = totobjsLABEL
                // runOBJQUERY(adoConn, sqlstring3, evtlList, objectlabel)
                //indnewitems(newevtlVIEW, newobjectlist, numobjcreated)
                //Else
                //MessageBox.Show("No Objects Created - Please select an object reference from the list", "No Items Selected")
                //End If
                //---------------------------

                //present message to the user if no items were created/selected
                if (srcobjVIEW.SelectedItems.Count <= 0)
                {
                    MessageBox.Show("No Objects Created - Please select an object reference from the list", "No Items Selected");
                }

                srcobjVIEW.SelectedItems.Clear();
            }
            else
            {
                refobj = "";
                refname = "";

            }

            //---------------------------------------------------------------------------------------------------------------------
            //disable the Create Object button until the network is queried again
            createBUTTON.Enabled = false;

            //---------------------------------------------------------------------------------------------------------------------
            //close the result set and ODBC connection
            adoConn.Close();
            adoConn = null;
            return;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Data Error Detected. Please ensure that you have enter a valid object reference, valid Device Address and correct ODBC DSN", "ODBC Reference Error");
                dsnTEXTBOX.Text = "Delta Network";
                adoConn.Close();
                adoConn = null;
                ProgressBar1.Value = 0;
            }
            

            //=======================================================
            //Service provided by Telerik (www.telerik.com)
            //Conversion powered by NRefactory.
            //Twitter: @telerik
            //Facebook: facebook.com/telerik
            //=======================================================

        }

        private void chkIsRemote_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIsRemote.Checked)
            {
                lblRemoteDevice.Visible = true;
                txtRemoteDevice.Visible = true;
            }
            else
            {
                lblRemoteDevice.Visible = false;
                txtRemoteDevice.Visible = false;
            }
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }

    //--------------------------------------------------------------------------------------------------
    //Class to map dictionary object type values into a property of the objectLIST combo box
    //This will be used to specify which TL or EV objects will  be displayed based on object reference
    //code snippets are from http://social.msdn.microsoft.com/Forums/en/winforms/thread/3e24d8b9-6841-43b3-89c8-c93d13fd0b33
    public class objectLIST
    {

        private string sOBJREF;

        private int iID;
        // Default empty constructor.
        public objectLIST()
        {
            sOBJREF = "";
            iID = 0;
        }

        public objectLIST(string Name, int ID)
        {
            sOBJREF = Name;
            iID = ID;
        }

        public string Name
        {
            get { return sOBJREF; }
            set { sOBJREF = value; }
        }

        // This is the property that holds the extra data.
        public Int32 ItemData
        {
            get { return iID; }
            set { iID = value; }
        }

        // This is neccessary because the ListBox and ComboBox rely
        // on this method when determining the text to display.
        public override string ToString()
        {
            return sOBJREF;
        }

    }




}

