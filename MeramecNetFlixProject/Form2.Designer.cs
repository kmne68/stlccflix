namespace MeramecNetFlixProject
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.Label member_numberLabel;
            System.Windows.Forms.Label joindateLabel;
            System.Windows.Forms.Label firstnameLabel;
            System.Windows.Forms.Label lastnameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label zipcodeLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label member_statusLabel;
            System.Windows.Forms.Label login_nameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label contact_methodLabel;
            System.Windows.Forms.Label subscription_idLabel;
            System.Windows.Forms.Label photoLabel;
            this.iS253_EmeryDataSet = new MeramecNetFlixProject.IS253_EmeryDataSet();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberTableAdapter = new MeramecNetFlixProject.IS253_EmeryDataSetTableAdapters.MemberTableAdapter();
            this.tableAdapterManager = new MeramecNetFlixProject.IS253_EmeryDataSetTableAdapters.TableAdapterManager();
            this.memberBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
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
            member_numberLabel = new System.Windows.Forms.Label();
            joindateLabel = new System.Windows.Forms.Label();
            firstnameLabel = new System.Windows.Forms.Label();
            lastnameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            zipcodeLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            member_statusLabel = new System.Windows.Forms.Label();
            login_nameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            contact_methodLabel = new System.Windows.Forms.Label();
            subscription_idLabel = new System.Windows.Forms.Label();
            photoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iS253_EmeryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingNavigator)).BeginInit();
            this.memberBindingNavigator.SuspendLayout();
            this.SuspendLayout();
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
            this.memberBindingNavigator.TabIndex = 0;
            this.memberBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // memberBindingNavigatorSaveItem
            // 
            this.memberBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.memberBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("memberBindingNavigatorSaveItem.Image")));
            this.memberBindingNavigatorSaveItem.Name = "memberBindingNavigatorSaveItem";
            this.memberBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.memberBindingNavigatorSaveItem.Text = "Save Data";
            this.memberBindingNavigatorSaveItem.Click += new System.EventHandler(this.memberBindingNavigatorSaveItem_Click_4);
            // 
            // member_numberLabel
            // 
            member_numberLabel.AutoSize = true;
            member_numberLabel.Location = new System.Drawing.Point(91, 93);
            member_numberLabel.Name = "member_numberLabel";
            member_numberLabel.Size = new System.Drawing.Size(85, 13);
            member_numberLabel.TabIndex = 1;
            member_numberLabel.Text = "member number:";
            // 
            // member_numberTextBox
            // 
            this.member_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "member_number", true));
            this.member_numberTextBox.Location = new System.Drawing.Point(182, 90);
            this.member_numberTextBox.Name = "member_numberTextBox";
            this.member_numberTextBox.Size = new System.Drawing.Size(200, 20);
            this.member_numberTextBox.TabIndex = 2;
            // 
            // joindateLabel
            // 
            joindateLabel.AutoSize = true;
            joindateLabel.Location = new System.Drawing.Point(91, 120);
            joindateLabel.Name = "joindateLabel";
            joindateLabel.Size = new System.Drawing.Size(47, 13);
            joindateLabel.TabIndex = 3;
            joindateLabel.Text = "joindate:";
            // 
            // joindateDateTimePicker
            // 
            this.joindateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.memberBindingSource, "joindate", true));
            this.joindateDateTimePicker.Location = new System.Drawing.Point(182, 116);
            this.joindateDateTimePicker.Name = "joindateDateTimePicker";
            this.joindateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.joindateDateTimePicker.TabIndex = 4;
            // 
            // firstnameLabel
            // 
            firstnameLabel.AutoSize = true;
            firstnameLabel.Location = new System.Drawing.Point(91, 145);
            firstnameLabel.Name = "firstnameLabel";
            firstnameLabel.Size = new System.Drawing.Size(52, 13);
            firstnameLabel.TabIndex = 5;
            firstnameLabel.Text = "firstname:";
            // 
            // firstnameTextBox
            // 
            this.firstnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "firstname", true));
            this.firstnameTextBox.Location = new System.Drawing.Point(182, 142);
            this.firstnameTextBox.Name = "firstnameTextBox";
            this.firstnameTextBox.Size = new System.Drawing.Size(200, 20);
            this.firstnameTextBox.TabIndex = 6;
            // 
            // lastnameLabel
            // 
            lastnameLabel.AutoSize = true;
            lastnameLabel.Location = new System.Drawing.Point(91, 171);
            lastnameLabel.Name = "lastnameLabel";
            lastnameLabel.Size = new System.Drawing.Size(52, 13);
            lastnameLabel.TabIndex = 7;
            lastnameLabel.Text = "lastname:";
            // 
            // lastnameTextBox
            // 
            this.lastnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "lastname", true));
            this.lastnameTextBox.Location = new System.Drawing.Point(182, 168);
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.Size = new System.Drawing.Size(200, 20);
            this.lastnameTextBox.TabIndex = 8;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(91, 197);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(47, 13);
            addressLabel.TabIndex = 9;
            addressLabel.Text = "address:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "address", true));
            this.addressTextBox.Location = new System.Drawing.Point(182, 194);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(200, 20);
            this.addressTextBox.TabIndex = 10;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(91, 223);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(26, 13);
            cityLabel.TabIndex = 11;
            cityLabel.Text = "city:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "city", true));
            this.cityTextBox.Location = new System.Drawing.Point(182, 220);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(200, 20);
            this.cityTextBox.TabIndex = 12;
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(91, 249);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(33, 13);
            stateLabel.TabIndex = 13;
            stateLabel.Text = "state:";
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "state", true));
            this.stateTextBox.Location = new System.Drawing.Point(182, 246);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(200, 20);
            this.stateTextBox.TabIndex = 14;
            // 
            // zipcodeLabel
            // 
            zipcodeLabel.AutoSize = true;
            zipcodeLabel.Location = new System.Drawing.Point(91, 275);
            zipcodeLabel.Name = "zipcodeLabel";
            zipcodeLabel.Size = new System.Drawing.Size(47, 13);
            zipcodeLabel.TabIndex = 15;
            zipcodeLabel.Text = "zipcode:";
            // 
            // zipcodeTextBox
            // 
            this.zipcodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "zipcode", true));
            this.zipcodeTextBox.Location = new System.Drawing.Point(182, 272);
            this.zipcodeTextBox.Name = "zipcodeTextBox";
            this.zipcodeTextBox.Size = new System.Drawing.Size(200, 20);
            this.zipcodeTextBox.TabIndex = 16;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(91, 301);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(40, 13);
            phoneLabel.TabIndex = 17;
            phoneLabel.Text = "phone:";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(182, 298);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(200, 20);
            this.phoneTextBox.TabIndex = 18;
            // 
            // member_statusLabel
            // 
            member_statusLabel.AutoSize = true;
            member_statusLabel.Location = new System.Drawing.Point(91, 327);
            member_statusLabel.Name = "member_statusLabel";
            member_statusLabel.Size = new System.Drawing.Size(78, 13);
            member_statusLabel.TabIndex = 19;
            member_statusLabel.Text = "member status:";
            // 
            // member_statusTextBox
            // 
            this.member_statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "member_status", true));
            this.member_statusTextBox.Location = new System.Drawing.Point(182, 324);
            this.member_statusTextBox.Name = "member_statusTextBox";
            this.member_statusTextBox.Size = new System.Drawing.Size(200, 20);
            this.member_statusTextBox.TabIndex = 20;
            // 
            // login_nameLabel
            // 
            login_nameLabel.AutoSize = true;
            login_nameLabel.Location = new System.Drawing.Point(91, 353);
            login_nameLabel.Name = "login_nameLabel";
            login_nameLabel.Size = new System.Drawing.Size(61, 13);
            login_nameLabel.TabIndex = 21;
            login_nameLabel.Text = "login name:";
            // 
            // login_nameTextBox
            // 
            this.login_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "login_name", true));
            this.login_nameTextBox.Location = new System.Drawing.Point(182, 350);
            this.login_nameTextBox.Name = "login_nameTextBox";
            this.login_nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.login_nameTextBox.TabIndex = 22;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(91, 379);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(55, 13);
            passwordLabel.TabIndex = 23;
            passwordLabel.Text = "password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(182, 376);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(200, 20);
            this.passwordTextBox.TabIndex = 24;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(91, 405);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(34, 13);
            emailLabel.TabIndex = 25;
            emailLabel.Text = "email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(182, 402);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 20);
            this.emailTextBox.TabIndex = 26;
            // 
            // contact_methodLabel
            // 
            contact_methodLabel.AutoSize = true;
            contact_methodLabel.Location = new System.Drawing.Point(91, 431);
            contact_methodLabel.Name = "contact_methodLabel";
            contact_methodLabel.Size = new System.Drawing.Size(84, 13);
            contact_methodLabel.TabIndex = 27;
            contact_methodLabel.Text = "contact method:";
            // 
            // contact_methodTextBox
            // 
            this.contact_methodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "contact_method", true));
            this.contact_methodTextBox.Location = new System.Drawing.Point(182, 428);
            this.contact_methodTextBox.Name = "contact_methodTextBox";
            this.contact_methodTextBox.Size = new System.Drawing.Size(200, 20);
            this.contact_methodTextBox.TabIndex = 28;
            // 
            // subscription_idLabel
            // 
            subscription_idLabel.AutoSize = true;
            subscription_idLabel.Location = new System.Drawing.Point(91, 457);
            subscription_idLabel.Name = "subscription_idLabel";
            subscription_idLabel.Size = new System.Drawing.Size(77, 13);
            subscription_idLabel.TabIndex = 29;
            subscription_idLabel.Text = "subscription id:";
            // 
            // subscription_idTextBox
            // 
            this.subscription_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "subscription_id", true));
            this.subscription_idTextBox.Location = new System.Drawing.Point(182, 454);
            this.subscription_idTextBox.Name = "subscription_idTextBox";
            this.subscription_idTextBox.Size = new System.Drawing.Size(200, 20);
            this.subscription_idTextBox.TabIndex = 30;
            // 
            // photoLabel
            // 
            photoLabel.AutoSize = true;
            photoLabel.Location = new System.Drawing.Point(91, 483);
            photoLabel.Name = "photoLabel";
            photoLabel.Size = new System.Drawing.Size(37, 13);
            photoLabel.TabIndex = 31;
            photoLabel.Text = "photo:";
            // 
            // photoTextBox
            // 
            this.photoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "photo", true));
            this.photoTextBox.Location = new System.Drawing.Point(182, 480);
            this.photoTextBox.Name = "photoTextBox";
            this.photoTextBox.Size = new System.Drawing.Size(200, 20);
            this.photoTextBox.TabIndex = 32;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(member_numberLabel);
            this.Controls.Add(this.member_numberTextBox);
            this.Controls.Add(joindateLabel);
            this.Controls.Add(this.joindateDateTimePicker);
            this.Controls.Add(firstnameLabel);
            this.Controls.Add(this.firstnameTextBox);
            this.Controls.Add(lastnameLabel);
            this.Controls.Add(this.lastnameTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(stateLabel);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(zipcodeLabel);
            this.Controls.Add(this.zipcodeTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(member_statusLabel);
            this.Controls.Add(this.member_statusTextBox);
            this.Controls.Add(login_nameLabel);
            this.Controls.Add(this.login_nameTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(contact_methodLabel);
            this.Controls.Add(this.contact_methodTextBox);
            this.Controls.Add(subscription_idLabel);
            this.Controls.Add(this.subscription_idTextBox);
            this.Controls.Add(photoLabel);
            this.Controls.Add(this.photoTextBox);
            this.Controls.Add(this.memberBindingNavigator);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iS253_EmeryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingNavigator)).EndInit();
            this.memberBindingNavigator.ResumeLayout(false);
            this.memberBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
    }
}