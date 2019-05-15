namespace MeramecNetFlixProject
{
    partial class Member
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label member_statusLabel;
            System.Windows.Forms.Label contact_methodLabel;
            System.Windows.Forms.Label subscription_idLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Member));
            this.rb_active = new System.Windows.Forms.RadioButton();
            this.rb_inact = new System.Windows.Forms.RadioButton();
            this.rb_contact1 = new System.Windows.Forms.RadioButton();
            this.rb_contact2 = new System.Windows.Forms.RadioButton();
            this.rb_contact3 = new System.Windows.Forms.RadioButton();
            this.rb_contact4 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_upload = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_browse = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.iS253_EmeryDataSet = new MeramecNetFlixProject.IS253_EmeryDataSet();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberTableAdapter = new MeramecNetFlixProject.IS253_EmeryDataSetTableAdapters.MemberTableAdapter();
            this.tableAdapterManager = new MeramecNetFlixProject.IS253_EmeryDataSetTableAdapters.TableAdapterManager();
            this.memberBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.memberBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.member_numberTextBox = new System.Windows.Forms.TextBox();
            this.joindateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.firstnameTextBox = new System.Windows.Forms.TextBox();
            this.lastnameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.zipcodeTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.member_statusTextBox = new System.Windows.Forms.TextBox();
            this.login_nameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.contact_methodTextBox = new System.Windows.Forms.TextBox();
            this.subscription_idTextBox = new System.Windows.Forms.TextBox();
            this.photoTextBox = new System.Windows.Forms.TextBox();
            this.gbx_memberStatus = new System.Windows.Forms.GroupBox();
            member_statusLabel = new System.Windows.Forms.Label();
            contact_methodLabel = new System.Windows.Forms.Label();
            subscription_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iS253_EmeryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingNavigator)).BeginInit();
            this.memberBindingNavigator.SuspendLayout();
            this.gbx_memberStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // member_statusLabel
            // 
            member_statusLabel.AutoSize = true;
            member_statusLabel.Location = new System.Drawing.Point(18, 224);
            member_statusLabel.Name = "member_statusLabel";
            member_statusLabel.Size = new System.Drawing.Size(78, 13);
            member_statusLabel.TabIndex = 57;
            member_statusLabel.Text = "member status:";
            // 
            // contact_methodLabel
            // 
            contact_methodLabel.AutoSize = true;
            contact_methodLabel.Location = new System.Drawing.Point(376, 227);
            contact_methodLabel.Name = "contact_methodLabel";
            contact_methodLabel.Size = new System.Drawing.Size(84, 13);
            contact_methodLabel.TabIndex = 65;
            contact_methodLabel.Text = "contact method:";
            // 
            // subscription_idLabel
            // 
            subscription_idLabel.AutoSize = true;
            subscription_idLabel.Location = new System.Drawing.Point(376, 253);
            subscription_idLabel.Name = "subscription_idLabel";
            subscription_idLabel.Size = new System.Drawing.Size(77, 13);
            subscription_idLabel.TabIndex = 67;
            subscription_idLabel.Text = "subscription id:";
            // 
            // rb_active
            // 
            this.rb_active.AutoSize = true;
            this.rb_active.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.memberBindingSource, "member_status", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.rb_active.Location = new System.Drawing.Point(23, 19);
            this.rb_active.Name = "rb_active";
            this.rb_active.Size = new System.Drawing.Size(55, 17);
            this.rb_active.TabIndex = 0;
            this.rb_active.TabStop = true;
            this.rb_active.Text = "Active";
            this.rb_active.UseVisualStyleBackColor = true;
            this.rb_active.CheckedChanged += new System.EventHandler(this.rb_active_CheckedChanged);
            // 
            // rb_inact
            // 
            this.rb_inact.AutoSize = true;
            this.rb_inact.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.memberBindingSource, "member_status", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.rb_inact.Location = new System.Drawing.Point(23, 42);
            this.rb_inact.Name = "rb_inact";
            this.rb_inact.Size = new System.Drawing.Size(63, 17);
            this.rb_inact.TabIndex = 1;
            this.rb_inact.TabStop = true;
            this.rb_inact.Text = "Inactive";
            this.rb_inact.UseVisualStyleBackColor = true;
            this.rb_inact.CheckedChanged += new System.EventHandler(this.rb_inact_CheckedChanged);
            // 
            // rb_contact1
            // 
            this.rb_contact1.AutoSize = true;
            this.rb_contact1.Location = new System.Drawing.Point(166, 52);
            this.rb_contact1.Name = "rb_contact1";
            this.rb_contact1.Size = new System.Drawing.Size(50, 17);
            this.rb_contact1.TabIndex = 2;
            this.rb_contact1.TabStop = true;
            this.rb_contact1.Text = "Email";
            this.rb_contact1.UseVisualStyleBackColor = true;
            // 
            // rb_contact2
            // 
            this.rb_contact2.AutoSize = true;
            this.rb_contact2.Location = new System.Drawing.Point(222, 52);
            this.rb_contact2.Name = "rb_contact2";
            this.rb_contact2.Size = new System.Drawing.Size(73, 17);
            this.rb_contact2.TabIndex = 3;
            this.rb_contact2.TabStop = true;
            this.rb_contact2.Text = "Facebook";
            this.rb_contact2.UseVisualStyleBackColor = true;
            // 
            // rb_contact3
            // 
            this.rb_contact3.AutoSize = true;
            this.rb_contact3.Location = new System.Drawing.Point(301, 52);
            this.rb_contact3.Name = "rb_contact3";
            this.rb_contact3.Size = new System.Drawing.Size(82, 17);
            this.rb_contact3.TabIndex = 4;
            this.rb_contact3.TabStop = true;
            this.rb_contact3.Text = "Text/Phone";
            this.rb_contact3.UseVisualStyleBackColor = true;
            // 
            // rb_contact4
            // 
            this.rb_contact4.AutoSize = true;
            this.rb_contact4.Location = new System.Drawing.Point(389, 52);
            this.rb_contact4.Name = "rb_contact4";
            this.rb_contact4.Size = new System.Drawing.Size(57, 17);
            this.rb_contact4.TabIndex = 5;
            this.rb_contact4.TabStop = true;
            this.rb_contact4.Text = "Twitter";
            this.rb_contact4.UseVisualStyleBackColor = true;
            this.rb_contact4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(514, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Photo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Member Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Join Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "First Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Last Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "City:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(352, 395);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "State:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(508, 395);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Zip Code:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 451);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Email:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(326, 451);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Login Name:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(505, 451);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Password:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 428);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Phone:";
            // 
            // btn_upload
            // 
            this.btn_upload.Location = new System.Drawing.Point(592, 340);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(75, 23);
            this.btn_upload.TabIndex = 31;
            this.btn_upload.Text = "Upload Image.";
            this.btn_upload.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(31, 510);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 32;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(112, 510);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(75, 23);
            this.btn_browse.TabIndex = 33;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(193, 510);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 34;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(274, 510);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 35;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(355, 510);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 36;
            this.button5.Text = "Clear";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(436, 510);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 37;
            this.button6.Text = "Exit";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // iS253_EmeryDataSet
            // 
            this.iS253_EmeryDataSet.DataSetName = "IS253_EmeryDataSet";
            this.iS253_EmeryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "Member";
            this.memberBindingSource.DataSource = this.iS253_EmeryDataSet;
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ContactMethodTableAdapter = null;
            this.tableAdapterManager.GenreTableAdapter = null;
            this.tableAdapterManager.MemberTableAdapter = this.memberTableAdapter;
            this.tableAdapterManager.MovieTableAdapter = null;
            this.tableAdapterManager.RentalTableAdapter = null;
            this.tableAdapterManager.SubscriptionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MeramecNetFlixProject.IS253_EmeryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendorTableAdapter = null;
            // 
            // memberBindingNavigator
            // 
            this.memberBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.memberBindingNavigator.BindingSource = this.memberBindingSource;
            this.memberBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.memberBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.memberBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.memberBindingNavigatorSaveItem});
            this.memberBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.memberBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.memberBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.memberBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.memberBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.memberBindingNavigator.Name = "memberBindingNavigator";
            this.memberBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.memberBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.memberBindingNavigator.TabIndex = 38;
            this.memberBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // memberBindingNavigatorSaveItem
            // 
            this.memberBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.memberBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("memberBindingNavigatorSaveItem.Image")));
            this.memberBindingNavigatorSaveItem.Name = "memberBindingNavigatorSaveItem";
            this.memberBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.memberBindingNavigatorSaveItem.Text = "Save Data";
            this.memberBindingNavigatorSaveItem.Click += new System.EventHandler(this.memberBindingNavigatorSaveItem_Click_2);
            // 
            // member_numberTextBox
            // 
            this.member_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "member_number", true));
            this.member_numberTextBox.Location = new System.Drawing.Point(112, 273);
            this.member_numberTextBox.Name = "member_numberTextBox";
            this.member_numberTextBox.Size = new System.Drawing.Size(200, 20);
            this.member_numberTextBox.TabIndex = 40;
            // 
            // joindateDateTimePicker
            // 
            this.joindateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.memberBindingSource, "joindate", true));
            this.joindateDateTimePicker.Location = new System.Drawing.Point(112, 297);
            this.joindateDateTimePicker.Name = "joindateDateTimePicker";
            this.joindateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.joindateDateTimePicker.TabIndex = 42;
            // 
            // firstnameTextBox
            // 
            this.firstnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "firstname", true));
            this.firstnameTextBox.Location = new System.Drawing.Point(112, 323);
            this.firstnameTextBox.Name = "firstnameTextBox";
            this.firstnameTextBox.Size = new System.Drawing.Size(200, 20);
            this.firstnameTextBox.TabIndex = 44;
            this.firstnameTextBox.TextChanged += new System.EventHandler(this.firstnameTextBox_TextChanged);
            // 
            // lastnameTextBox
            // 
            this.lastnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "lastname", true));
            this.lastnameTextBox.Location = new System.Drawing.Point(112, 347);
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.Size = new System.Drawing.Size(200, 20);
            this.lastnameTextBox.TabIndex = 46;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "address", true));
            this.addressTextBox.Location = new System.Drawing.Point(112, 373);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(200, 20);
            this.addressTextBox.TabIndex = 48;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "city", true));
            this.cityTextBox.Location = new System.Drawing.Point(112, 399);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(200, 20);
            this.cityTextBox.TabIndex = 50;
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "state", true));
            this.stateTextBox.Location = new System.Drawing.Point(389, 392);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(110, 20);
            this.stateTextBox.TabIndex = 52;
            // 
            // zipcodeTextBox
            // 
            this.zipcodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "zipcode", true));
            this.zipcodeTextBox.Location = new System.Drawing.Point(567, 392);
            this.zipcodeTextBox.Name = "zipcodeTextBox";
            this.zipcodeTextBox.Size = new System.Drawing.Size(200, 20);
            this.zipcodeTextBox.TabIndex = 54;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(112, 425);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(200, 20);
            this.phoneTextBox.TabIndex = 56;
            // 
            // member_statusTextBox
            // 
            this.member_statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "member_status", true));
            this.member_statusTextBox.Location = new System.Drawing.Point(109, 221);
            this.member_statusTextBox.Name = "member_statusTextBox";
            this.member_statusTextBox.Size = new System.Drawing.Size(200, 20);
            this.member_statusTextBox.TabIndex = 58;
            // 
            // login_nameTextBox
            // 
            this.login_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "login_name", true));
            this.login_nameTextBox.Location = new System.Drawing.Point(389, 448);
            this.login_nameTextBox.Name = "login_nameTextBox";
            this.login_nameTextBox.Size = new System.Drawing.Size(110, 20);
            this.login_nameTextBox.TabIndex = 60;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(567, 448);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(200, 20);
            this.passwordTextBox.TabIndex = 62;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(112, 451);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 20);
            this.emailTextBox.TabIndex = 64;
            // 
            // contact_methodTextBox
            // 
            this.contact_methodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "contact_method", true));
            this.contact_methodTextBox.Location = new System.Drawing.Point(467, 224);
            this.contact_methodTextBox.Name = "contact_methodTextBox";
            this.contact_methodTextBox.Size = new System.Drawing.Size(200, 20);
            this.contact_methodTextBox.TabIndex = 66;
            // 
            // subscription_idTextBox
            // 
            this.subscription_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "subscription_id", true));
            this.subscription_idTextBox.Location = new System.Drawing.Point(467, 250);
            this.subscription_idTextBox.Name = "subscription_idTextBox";
            this.subscription_idTextBox.Size = new System.Drawing.Size(200, 20);
            this.subscription_idTextBox.TabIndex = 68;
            // 
            // photoTextBox
            // 
            this.photoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "photo", true));
            this.photoTextBox.Location = new System.Drawing.Point(563, 49);
            this.photoTextBox.Name = "photoTextBox";
            this.photoTextBox.Size = new System.Drawing.Size(200, 20);
            this.photoTextBox.TabIndex = 70;
            // 
            // gbx_memberStatus
            // 
            this.gbx_memberStatus.Controls.Add(this.rb_active);
            this.gbx_memberStatus.Controls.Add(this.rb_inact);
            this.gbx_memberStatus.Location = new System.Drawing.Point(109, 104);
            this.gbx_memberStatus.Name = "gbx_memberStatus";
            this.gbx_memberStatus.Size = new System.Drawing.Size(138, 79);
            this.gbx_memberStatus.TabIndex = 71;
            this.gbx_memberStatus.TabStop = false;
            this.gbx_memberStatus.Text = "Member Status";
            // 
            // Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 806);
            this.Controls.Add(this.gbx_memberStatus);
            this.Controls.Add(this.member_numberTextBox);
            this.Controls.Add(this.joindateDateTimePicker);
            this.Controls.Add(this.firstnameTextBox);
            this.Controls.Add(this.lastnameTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(this.zipcodeTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(member_statusLabel);
            this.Controls.Add(this.member_statusTextBox);
            this.Controls.Add(this.login_nameTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(contact_methodLabel);
            this.Controls.Add(this.contact_methodTextBox);
            this.Controls.Add(subscription_idLabel);
            this.Controls.Add(this.subscription_idTextBox);
            this.Controls.Add(this.photoTextBox);
            this.Controls.Add(this.memberBindingNavigator);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_upload);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rb_contact4);
            this.Controls.Add(this.rb_contact3);
            this.Controls.Add(this.rb_contact2);
            this.Controls.Add(this.rb_contact1);
            this.Name = "Member";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Member_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iS253_EmeryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingNavigator)).EndInit();
            this.memberBindingNavigator.ResumeLayout(false);
            this.memberBindingNavigator.PerformLayout();
            this.gbx_memberStatus.ResumeLayout(false);
            this.gbx_memberStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_active;
        private System.Windows.Forms.RadioButton rb_inact;
        private System.Windows.Forms.RadioButton rb_contact1;
        private System.Windows.Forms.RadioButton rb_contact2;
        private System.Windows.Forms.RadioButton rb_contact3;
        private System.Windows.Forms.RadioButton rb_contact4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private IS253_EmeryDataSet iS253_EmeryDataSet;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private IS253_EmeryDataSetTableAdapters.MemberTableAdapter memberTableAdapter;
        private IS253_EmeryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator memberBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton memberBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox member_numberTextBox;
        private System.Windows.Forms.DateTimePicker joindateDateTimePicker;
        private System.Windows.Forms.TextBox firstnameTextBox;
        private System.Windows.Forms.TextBox lastnameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox zipcodeTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox member_statusTextBox;
        private System.Windows.Forms.TextBox login_nameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox contact_methodTextBox;
        private System.Windows.Forms.TextBox subscription_idTextBox;
        private System.Windows.Forms.TextBox photoTextBox;
        private System.Windows.Forms.GroupBox gbx_memberStatus;
    }
}