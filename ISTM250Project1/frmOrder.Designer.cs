namespace ISTM250Project1
{
    partial class frmOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnCompleteOrder = new System.Windows.Forms.Button();
            this.btnClearOrder = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gboDelivery = new System.Windows.Forms.GroupBox();
            this.txtDeliverySubdivision = new System.Windows.Forms.TextBox();
            this.txtDeliveryPhone = new System.Windows.Forms.TextBox();
            this.txtDeliveryZip = new System.Windows.Forms.TextBox();
            this.txtDeliveryState = new System.Windows.Forms.TextBox();
            this.txtDeliveryCity = new System.Windows.Forms.TextBox();
            this.txtDeliveryStreet = new System.Windows.Forms.TextBox();
            this.txtDeliveryName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gboCustomer = new System.Windows.Forms.GroupBox();
            this.txtCustomerStreet = new System.Windows.Forms.TextBox();
            this.txtCustomerCity = new System.Windows.Forms.TextBox();
            this.txtCustomerState = new System.Windows.Forms.TextBox();
            this.txtCustomerZip = new System.Windows.Forms.TextBox();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.txtCustomerSubdivision = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rdoCarryOut = new System.Windows.Forms.RadioButton();
            this.rdoDelivery = new System.Windows.Forms.RadioButton();
            this.gboOrder = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtOrderTotal = new System.Windows.Forms.TextBox();
            this.cboItem = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cboSpecialtyItem = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.cboBreadCrust = new System.Windows.Forms.ComboBox();
            this.lstYourOrder = new System.Windows.Forms.ListBox();
            this.pboDeliPicture = new System.Windows.Forms.PictureBox();
            this.label21 = new System.Windows.Forms.Label();
            this.pboPizzaPicture = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnVendor = new System.Windows.Forms.Button();
            this.gboDelivery.SuspendLayout();
            this.gboCustomer.SuspendLayout();
            this.gboOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboDeliPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboPizzaPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(19, 140);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(105, 25);
            this.btnAddItem.TabIndex = 5;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnCompleteOrder
            // 
            this.btnCompleteOrder.Location = new System.Drawing.Point(144, 140);
            this.btnCompleteOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnCompleteOrder.Name = "btnCompleteOrder";
            this.btnCompleteOrder.Size = new System.Drawing.Size(105, 25);
            this.btnCompleteOrder.TabIndex = 6;
            this.btnCompleteOrder.Text = "Complete Order";
            this.btnCompleteOrder.UseVisualStyleBackColor = true;
            this.btnCompleteOrder.Click += new System.EventHandler(this.btnCompleteOrder_Click);
            // 
            // btnClearOrder
            // 
            this.btnClearOrder.Location = new System.Drawing.Point(19, 169);
            this.btnClearOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearOrder.Name = "btnClearOrder";
            this.btnClearOrder.Size = new System.Drawing.Size(105, 19);
            this.btnClearOrder.TabIndex = 7;
            this.btnClearOrder.Text = "Clear Order";
            this.btnClearOrder.UseVisualStyleBackColor = true;
            this.btnClearOrder.Click += new System.EventHandler(this.btnClearOrder_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(144, 169);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 19);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gboDelivery
            // 
            this.gboDelivery.Controls.Add(this.txtDeliverySubdivision);
            this.gboDelivery.Controls.Add(this.txtDeliveryPhone);
            this.gboDelivery.Controls.Add(this.txtDeliveryZip);
            this.gboDelivery.Controls.Add(this.txtDeliveryState);
            this.gboDelivery.Controls.Add(this.txtDeliveryCity);
            this.gboDelivery.Controls.Add(this.txtDeliveryStreet);
            this.gboDelivery.Controls.Add(this.txtDeliveryName);
            this.gboDelivery.Controls.Add(this.label7);
            this.gboDelivery.Controls.Add(this.label6);
            this.gboDelivery.Controls.Add(this.label5);
            this.gboDelivery.Controls.Add(this.label4);
            this.gboDelivery.Controls.Add(this.label3);
            this.gboDelivery.Controls.Add(this.label2);
            this.gboDelivery.Controls.Add(this.label1);
            this.gboDelivery.Location = new System.Drawing.Point(352, 74);
            this.gboDelivery.Margin = new System.Windows.Forms.Padding(2);
            this.gboDelivery.Name = "gboDelivery";
            this.gboDelivery.Padding = new System.Windows.Forms.Padding(2);
            this.gboDelivery.Size = new System.Drawing.Size(308, 225);
            this.gboDelivery.TabIndex = 3;
            this.gboDelivery.TabStop = false;
            this.gboDelivery.Text = "Delivery Information";
            // 
            // txtDeliverySubdivision
            // 
            this.txtDeliverySubdivision.Location = new System.Drawing.Point(148, 161);
            this.txtDeliverySubdivision.Margin = new System.Windows.Forms.Padding(2);
            this.txtDeliverySubdivision.Name = "txtDeliverySubdivision";
            this.txtDeliverySubdivision.Size = new System.Drawing.Size(76, 20);
            this.txtDeliverySubdivision.TabIndex = 6;
            // 
            // txtDeliveryPhone
            // 
            this.txtDeliveryPhone.Location = new System.Drawing.Point(148, 138);
            this.txtDeliveryPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtDeliveryPhone.Name = "txtDeliveryPhone";
            this.txtDeliveryPhone.Size = new System.Drawing.Size(76, 20);
            this.txtDeliveryPhone.TabIndex = 5;
            // 
            // txtDeliveryZip
            // 
            this.txtDeliveryZip.Location = new System.Drawing.Point(148, 115);
            this.txtDeliveryZip.Margin = new System.Windows.Forms.Padding(2);
            this.txtDeliveryZip.Name = "txtDeliveryZip";
            this.txtDeliveryZip.Size = new System.Drawing.Size(76, 20);
            this.txtDeliveryZip.TabIndex = 4;
            // 
            // txtDeliveryState
            // 
            this.txtDeliveryState.Location = new System.Drawing.Point(148, 93);
            this.txtDeliveryState.Margin = new System.Windows.Forms.Padding(2);
            this.txtDeliveryState.Name = "txtDeliveryState";
            this.txtDeliveryState.Size = new System.Drawing.Size(76, 20);
            this.txtDeliveryState.TabIndex = 3;
            // 
            // txtDeliveryCity
            // 
            this.txtDeliveryCity.Location = new System.Drawing.Point(148, 71);
            this.txtDeliveryCity.Margin = new System.Windows.Forms.Padding(2);
            this.txtDeliveryCity.Name = "txtDeliveryCity";
            this.txtDeliveryCity.Size = new System.Drawing.Size(76, 20);
            this.txtDeliveryCity.TabIndex = 2;
            // 
            // txtDeliveryStreet
            // 
            this.txtDeliveryStreet.Location = new System.Drawing.Point(148, 48);
            this.txtDeliveryStreet.Margin = new System.Windows.Forms.Padding(2);
            this.txtDeliveryStreet.Name = "txtDeliveryStreet";
            this.txtDeliveryStreet.Size = new System.Drawing.Size(76, 20);
            this.txtDeliveryStreet.TabIndex = 1;
            // 
            // txtDeliveryName
            // 
            this.txtDeliveryName.Location = new System.Drawing.Point(148, 24);
            this.txtDeliveryName.Margin = new System.Windows.Forms.Padding(2);
            this.txtDeliveryName.Name = "txtDeliveryName";
            this.txtDeliveryName.Size = new System.Drawing.Size(76, 20);
            this.txtDeliveryName.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 163);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Subdivision Location:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 142);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Phone Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 119);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Zip Code:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "State:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "City:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Street:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // gboCustomer
            // 
            this.gboCustomer.Controls.Add(this.txtCustomerStreet);
            this.gboCustomer.Controls.Add(this.txtCustomerCity);
            this.gboCustomer.Controls.Add(this.txtCustomerState);
            this.gboCustomer.Controls.Add(this.txtCustomerZip);
            this.gboCustomer.Controls.Add(this.txtCustomerPhone);
            this.gboCustomer.Controls.Add(this.txtCustomerSubdivision);
            this.gboCustomer.Controls.Add(this.txtCustomerName);
            this.gboCustomer.Controls.Add(this.label14);
            this.gboCustomer.Controls.Add(this.label13);
            this.gboCustomer.Controls.Add(this.label12);
            this.gboCustomer.Controls.Add(this.label11);
            this.gboCustomer.Controls.Add(this.label10);
            this.gboCustomer.Controls.Add(this.label9);
            this.gboCustomer.Controls.Add(this.label8);
            this.gboCustomer.Location = new System.Drawing.Point(22, 74);
            this.gboCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.gboCustomer.Name = "gboCustomer";
            this.gboCustomer.Padding = new System.Windows.Forms.Padding(2);
            this.gboCustomer.Size = new System.Drawing.Size(298, 225);
            this.gboCustomer.TabIndex = 2;
            this.gboCustomer.TabStop = false;
            this.gboCustomer.Text = "Customer Information";
            // 
            // txtCustomerStreet
            // 
            this.txtCustomerStreet.Location = new System.Drawing.Point(161, 46);
            this.txtCustomerStreet.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomerStreet.Name = "txtCustomerStreet";
            this.txtCustomerStreet.ReadOnly = true;
            this.txtCustomerStreet.Size = new System.Drawing.Size(76, 20);
            this.txtCustomerStreet.TabIndex = 1;
            this.txtCustomerStreet.Text = "123 Main Street";
            // 
            // txtCustomerCity
            // 
            this.txtCustomerCity.Location = new System.Drawing.Point(161, 69);
            this.txtCustomerCity.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomerCity.Name = "txtCustomerCity";
            this.txtCustomerCity.ReadOnly = true;
            this.txtCustomerCity.Size = new System.Drawing.Size(76, 20);
            this.txtCustomerCity.TabIndex = 2;
            this.txtCustomerCity.Text = "Bryan";
            // 
            // txtCustomerState
            // 
            this.txtCustomerState.Location = new System.Drawing.Point(161, 93);
            this.txtCustomerState.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomerState.Name = "txtCustomerState";
            this.txtCustomerState.ReadOnly = true;
            this.txtCustomerState.Size = new System.Drawing.Size(76, 20);
            this.txtCustomerState.TabIndex = 3;
            this.txtCustomerState.Text = "TX";
            // 
            // txtCustomerZip
            // 
            this.txtCustomerZip.Location = new System.Drawing.Point(161, 115);
            this.txtCustomerZip.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomerZip.Name = "txtCustomerZip";
            this.txtCustomerZip.ReadOnly = true;
            this.txtCustomerZip.Size = new System.Drawing.Size(76, 20);
            this.txtCustomerZip.TabIndex = 4;
            this.txtCustomerZip.Text = "12345";
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Location = new System.Drawing.Point(161, 138);
            this.txtCustomerPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.ReadOnly = true;
            this.txtCustomerPhone.Size = new System.Drawing.Size(76, 20);
            this.txtCustomerPhone.TabIndex = 5;
            this.txtCustomerPhone.Text = "1234567890";
            // 
            // txtCustomerSubdivision
            // 
            this.txtCustomerSubdivision.Location = new System.Drawing.Point(161, 161);
            this.txtCustomerSubdivision.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomerSubdivision.Name = "txtCustomerSubdivision";
            this.txtCustomerSubdivision.ReadOnly = true;
            this.txtCustomerSubdivision.Size = new System.Drawing.Size(76, 20);
            this.txtCustomerSubdivision.TabIndex = 6;
            this.txtCustomerSubdivision.Text = "Northwest";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(161, 24);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(76, 20);
            this.txtCustomerName.TabIndex = 0;
            this.txtCustomerName.Text = "John Smith";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(37, 141);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Phone Number:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(37, 165);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Subdivision Location:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(37, 116);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Zip Code:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 97);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "State:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 72);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "City:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 49);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Street address:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 28);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Name:";
            // 
            // rdoCarryOut
            // 
            this.rdoCarryOut.AutoSize = true;
            this.rdoCarryOut.Location = new System.Drawing.Point(253, 352);
            this.rdoCarryOut.Margin = new System.Windows.Forms.Padding(2);
            this.rdoCarryOut.Name = "rdoCarryOut";
            this.rdoCarryOut.Size = new System.Drawing.Size(69, 17);
            this.rdoCarryOut.TabIndex = 0;
            this.rdoCarryOut.TabStop = true;
            this.rdoCarryOut.Text = "Carry Out";
            this.rdoCarryOut.UseVisualStyleBackColor = true;
            this.rdoCarryOut.CheckedChanged += new System.EventHandler(this.rdoCarryOut_CheckedChanged);
            // 
            // rdoDelivery
            // 
            this.rdoDelivery.AutoSize = true;
            this.rdoDelivery.Location = new System.Drawing.Point(370, 352);
            this.rdoDelivery.Margin = new System.Windows.Forms.Padding(2);
            this.rdoDelivery.Name = "rdoDelivery";
            this.rdoDelivery.Size = new System.Drawing.Size(63, 17);
            this.rdoDelivery.TabIndex = 1;
            this.rdoDelivery.TabStop = true;
            this.rdoDelivery.Text = "Delivery";
            this.rdoDelivery.UseVisualStyleBackColor = true;
            this.rdoDelivery.CheckedChanged += new System.EventHandler(this.rdoDelivery_CheckedChanged);
            // 
            // gboOrder
            // 
            this.gboOrder.Controls.Add(this.label19);
            this.gboOrder.Controls.Add(this.label20);
            this.gboOrder.Controls.Add(this.txtOrderTotal);
            this.gboOrder.Controls.Add(this.cboItem);
            this.gboOrder.Controls.Add(this.label18);
            this.gboOrder.Controls.Add(this.cboSpecialtyItem);
            this.gboOrder.Controls.Add(this.label17);
            this.gboOrder.Controls.Add(this.label16);
            this.gboOrder.Controls.Add(this.txtQuantity);
            this.gboOrder.Controls.Add(this.cboBreadCrust);
            this.gboOrder.Controls.Add(this.btnClose);
            this.gboOrder.Controls.Add(this.btnAddItem);
            this.gboOrder.Controls.Add(this.btnClearOrder);
            this.gboOrder.Controls.Add(this.btnCompleteOrder);
            this.gboOrder.Location = new System.Drawing.Point(22, 388);
            this.gboOrder.Margin = new System.Windows.Forms.Padding(2);
            this.gboOrder.Name = "gboOrder";
            this.gboOrder.Padding = new System.Windows.Forms.Padding(2);
            this.gboOrder.Size = new System.Drawing.Size(277, 261);
            this.gboOrder.TabIndex = 4;
            this.gboOrder.TabStop = false;
            this.gboOrder.Text = "Order";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(68, 31);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(30, 13);
            this.label19.TabIndex = 12;
            this.label19.Text = "Item:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(57, 208);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 13);
            this.label20.TabIndex = 12;
            this.label20.Text = "Order Total:";
            // 
            // txtOrderTotal
            // 
            this.txtOrderTotal.Location = new System.Drawing.Point(125, 205);
            this.txtOrderTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrderTotal.Name = "txtOrderTotal";
            this.txtOrderTotal.ReadOnly = true;
            this.txtOrderTotal.Size = new System.Drawing.Size(76, 20);
            this.txtOrderTotal.TabIndex = 13;
            // 
            // cboItem
            // 
            this.cboItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboItem.FormattingEnabled = true;
            this.cboItem.Location = new System.Drawing.Point(100, 29);
            this.cboItem.Margin = new System.Windows.Forms.Padding(2);
            this.cboItem.Name = "cboItem";
            this.cboItem.Size = new System.Drawing.Size(92, 21);
            this.cboItem.TabIndex = 0;
            this.cboItem.SelectedIndexChanged += new System.EventHandler(this.cboItem_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(16, 56);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(81, 13);
            this.label18.TabIndex = 17;
            this.label18.Text = "Specialty Items:";
            // 
            // cboSpecialtyItem
            // 
            this.cboSpecialtyItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSpecialtyItem.FormattingEnabled = true;
            this.cboSpecialtyItem.Location = new System.Drawing.Point(100, 54);
            this.cboSpecialtyItem.Margin = new System.Windows.Forms.Padding(2);
            this.cboSpecialtyItem.Name = "cboSpecialtyItem";
            this.cboSpecialtyItem.Size = new System.Drawing.Size(92, 21);
            this.cboSpecialtyItem.TabIndex = 1;
            this.cboSpecialtyItem.SelectedIndexChanged += new System.EventHandler(this.cboSpecialtyItem_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(47, 109);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 13);
            this.label17.TabIndex = 15;
            this.label17.Text = "Quantity:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(31, 84);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "Bread/Crust:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(100, 107);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(76, 20);
            this.txtQuantity.TabIndex = 4;
            // 
            // cboBreadCrust
            // 
            this.cboBreadCrust.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBreadCrust.FormattingEnabled = true;
            this.cboBreadCrust.Location = new System.Drawing.Point(100, 81);
            this.cboBreadCrust.Margin = new System.Windows.Forms.Padding(2);
            this.cboBreadCrust.Name = "cboBreadCrust";
            this.cboBreadCrust.Size = new System.Drawing.Size(92, 21);
            this.cboBreadCrust.TabIndex = 3;
            // 
            // lstYourOrder
            // 
            this.lstYourOrder.FormattingEnabled = true;
            this.lstYourOrder.Location = new System.Drawing.Point(304, 501);
            this.lstYourOrder.Margin = new System.Windows.Forms.Padding(2);
            this.lstYourOrder.Name = "lstYourOrder";
            this.lstYourOrder.Size = new System.Drawing.Size(366, 147);
            this.lstYourOrder.TabIndex = 10;
            // 
            // pboDeliPicture
            // 
            this.pboDeliPicture.Image = global::ISTM250Project1.Properties.Resources.deli;
            this.pboDeliPicture.Location = new System.Drawing.Point(335, 416);
            this.pboDeliPicture.Margin = new System.Windows.Forms.Padding(2);
            this.pboDeliPicture.Name = "pboDeliPicture";
            this.pboDeliPicture.Size = new System.Drawing.Size(119, 61);
            this.pboDeliPicture.TabIndex = 11;
            this.pboDeliPicture.TabStop = false;
            this.pboDeliPicture.Visible = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(302, 319);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(85, 17);
            this.label21.TabIndex = 14;
            this.label21.Text = "Order Type:";
            // 
            // pboPizzaPicture
            // 
            this.pboPizzaPicture.Image = global::ISTM250Project1.Properties.Resources.pizza;
            this.pboPizzaPicture.Location = new System.Drawing.Point(486, 400);
            this.pboPizzaPicture.Margin = new System.Windows.Forms.Padding(2);
            this.pboPizzaPicture.Name = "pboPizzaPicture";
            this.pboPizzaPicture.Size = new System.Drawing.Size(132, 86);
            this.pboPizzaPicture.TabIndex = 15;
            this.pboPizzaPicture.TabStop = false;
            this.pboPizzaPicture.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(256, 20);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(176, 36);
            this.label15.TabIndex = 16;
            this.label15.Text = "Kirby\'s Deli";
            // 
            // btnInventory
            // 
            this.btnInventory.Location = new System.Drawing.Point(254, 667);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(75, 23);
            this.btnInventory.TabIndex = 17;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.BtnInventory_Click);
            // 
            // btnVendor
            // 
            this.btnVendor.Location = new System.Drawing.Point(335, 667);
            this.btnVendor.Name = "btnVendor";
            this.btnVendor.Size = new System.Drawing.Size(75, 23);
            this.btnVendor.TabIndex = 18;
            this.btnVendor.Text = "Vendor";
            this.btnVendor.UseVisualStyleBackColor = true;
            this.btnVendor.Click += new System.EventHandler(this.BtnVendor_Click);
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 718);
            this.Controls.Add(this.btnVendor);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.pboPizzaPicture);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.pboDeliPicture);
            this.Controls.Add(this.lstYourOrder);
            this.Controls.Add(this.gboOrder);
            this.Controls.Add(this.rdoDelivery);
            this.Controls.Add(this.rdoCarryOut);
            this.Controls.Add(this.gboCustomer);
            this.Controls.Add(this.gboDelivery);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kirby\'s Deli Order Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOrder_FormClosing);
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.gboDelivery.ResumeLayout(false);
            this.gboDelivery.PerformLayout();
            this.gboCustomer.ResumeLayout(false);
            this.gboCustomer.PerformLayout();
            this.gboOrder.ResumeLayout(false);
            this.gboOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboDeliPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboPizzaPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnCompleteOrder;
        private System.Windows.Forms.Button btnClearOrder;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gboDelivery;
        private System.Windows.Forms.TextBox txtDeliverySubdivision;
        private System.Windows.Forms.TextBox txtDeliveryPhone;
        private System.Windows.Forms.TextBox txtDeliveryZip;
        private System.Windows.Forms.TextBox txtDeliveryState;
        private System.Windows.Forms.TextBox txtDeliveryCity;
        private System.Windows.Forms.TextBox txtDeliveryStreet;
        private System.Windows.Forms.TextBox txtDeliveryName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gboCustomer;
        private System.Windows.Forms.TextBox txtCustomerStreet;
        private System.Windows.Forms.TextBox txtCustomerCity;
        private System.Windows.Forms.TextBox txtCustomerState;
        private System.Windows.Forms.TextBox txtCustomerZip;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.TextBox txtCustomerSubdivision;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rdoCarryOut;
        private System.Windows.Forms.RadioButton rdoDelivery;
        private System.Windows.Forms.GroupBox gboOrder;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.ComboBox cboSpecialtyItem;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cboBreadCrust;
        private System.Windows.Forms.ListBox lstYourOrder;
        private System.Windows.Forms.Label label19;
        public System.Windows.Forms.ComboBox cboItem;
        private System.Windows.Forms.PictureBox pboDeliPicture;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.PictureBox pboPizzaPicture;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnVendor;
    }
}

