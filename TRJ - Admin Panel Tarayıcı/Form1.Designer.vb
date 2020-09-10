<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnKaydet = New Bunifu.Framework.UI.BunifuImageButton()
        Me.lblToplamPanelUrl = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblBulunanlar = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblTarananlar = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblRobots = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnPanelUrlEkle = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnTara = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.tbUrl = New Bunifu.Framework.UI.BunifuTextbox()
        Me.pbTurkHacks = New System.Windows.Forms.PictureBox()
        Me.header = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnKapat = New Bunifu.Framework.UI.BunifuImageButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.lbPanelUrl = New System.Windows.Forms.ListBox()
        Me.lbBulunan = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ofdDosya = New System.Windows.Forms.OpenFileDialog()
        Me.tmrTara = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.wbUrl = New System.Windows.Forms.WebBrowser()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.btnKaydet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbTurkHacks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.header.SuspendLayout()
        CType(Me.btnKapat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.btnPanelUrlEkle)
        Me.Panel1.Controls.Add(Me.btnTara)
        Me.Panel1.Controls.Add(Me.tbUrl)
        Me.Panel1.Controls.Add(Me.pbTurkHacks)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(303, 514)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnKaydet)
        Me.GroupBox1.Controls.Add(Me.lblToplamPanelUrl)
        Me.GroupBox1.Controls.Add(Me.lblBulunanlar)
        Me.GroupBox1.Controls.Add(Me.lblTarananlar)
        Me.GroupBox1.Controls.Add(Me.lblRobots)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel5)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel4)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel3)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel2)
        Me.GroupBox1.ForeColor = System.Drawing.Color.SeaGreen
        Me.GroupBox1.Location = New System.Drawing.Point(18, 297)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(272, 136)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bilgiler"
        '
        'btnKaydet
        '
        Me.btnKaydet.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnKaydet.Image = CType(resources.GetObject("btnKaydet.Image"), System.Drawing.Image)
        Me.btnKaydet.ImageActive = Nothing
        Me.btnKaydet.Location = New System.Drawing.Point(218, 82)
        Me.btnKaydet.Name = "btnKaydet"
        Me.btnKaydet.Size = New System.Drawing.Size(48, 48)
        Me.btnKaydet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnKaydet.TabIndex = 8
        Me.btnKaydet.TabStop = False
        Me.btnKaydet.Zoom = 10
        '
        'lblToplamPanelUrl
        '
        Me.lblToplamPanelUrl.AutoSize = True
        Me.lblToplamPanelUrl.Font = New System.Drawing.Font("Consolas", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblToplamPanelUrl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblToplamPanelUrl.Location = New System.Drawing.Point(146, 100)
        Me.lblToplamPanelUrl.Name = "lblToplamPanelUrl"
        Me.lblToplamPanelUrl.Size = New System.Drawing.Size(16, 17)
        Me.lblToplamPanelUrl.TabIndex = 11
        Me.lblToplamPanelUrl.Text = "0"
        '
        'lblBulunanlar
        '
        Me.lblBulunanlar.AutoSize = True
        Me.lblBulunanlar.Font = New System.Drawing.Font("Consolas", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblBulunanlar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblBulunanlar.Location = New System.Drawing.Point(98, 76)
        Me.lblBulunanlar.Name = "lblBulunanlar"
        Me.lblBulunanlar.Size = New System.Drawing.Size(16, 17)
        Me.lblBulunanlar.TabIndex = 10
        Me.lblBulunanlar.Text = "0"
        '
        'lblTarananlar
        '
        Me.lblTarananlar.AutoSize = True
        Me.lblTarananlar.Font = New System.Drawing.Font("Consolas", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblTarananlar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTarananlar.Location = New System.Drawing.Point(98, 51)
        Me.lblTarananlar.Name = "lblTarananlar"
        Me.lblTarananlar.Size = New System.Drawing.Size(16, 17)
        Me.lblTarananlar.TabIndex = 9
        Me.lblTarananlar.Text = "0"
        '
        'lblRobots
        '
        Me.lblRobots.AutoSize = True
        Me.lblRobots.Font = New System.Drawing.Font("Consolas", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblRobots.ForeColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblRobots.Location = New System.Drawing.Point(96, 29)
        Me.lblRobots.Name = "lblRobots"
        Me.lblRobots.Size = New System.Drawing.Size(32, 17)
        Me.lblRobots.TabIndex = 8
        Me.lblRobots.Text = "---"
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Consolas", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(6, 29)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(96, 17)
        Me.BunifuCustomLabel5.TabIndex = 7
        Me.BunifuCustomLabel5.Text = "Robots.txt:"
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Consolas", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(6, 100)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(144, 17)
        Me.BunifuCustomLabel4.TabIndex = 6
        Me.BunifuCustomLabel4.Text = "Toplam Panel Url:"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Consolas", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(6, 51)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(96, 17)
        Me.BunifuCustomLabel3.TabIndex = 5
        Me.BunifuCustomLabel3.Text = "Tarananlar:"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Consolas", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(6, 76)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(96, 17)
        Me.BunifuCustomLabel2.TabIndex = 4
        Me.BunifuCustomLabel2.Text = "Bulunanlar:"
        '
        'btnPanelUrlEkle
        '
        Me.btnPanelUrlEkle.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnPanelUrlEkle.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnPanelUrlEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPanelUrlEkle.BorderRadius = 0
        Me.btnPanelUrlEkle.ButtonText = "               Panel Url Ekle"
        Me.btnPanelUrlEkle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPanelUrlEkle.DisabledColor = System.Drawing.Color.Gray
        Me.btnPanelUrlEkle.Iconcolor = System.Drawing.Color.Transparent
        Me.btnPanelUrlEkle.Iconimage = CType(resources.GetObject("btnPanelUrlEkle.Iconimage"), System.Drawing.Image)
        Me.btnPanelUrlEkle.Iconimage_right = Nothing
        Me.btnPanelUrlEkle.Iconimage_right_Selected = Nothing
        Me.btnPanelUrlEkle.Iconimage_Selected = Nothing
        Me.btnPanelUrlEkle.IconMarginLeft = 0
        Me.btnPanelUrlEkle.IconMarginRight = 0
        Me.btnPanelUrlEkle.IconRightVisible = True
        Me.btnPanelUrlEkle.IconRightZoom = 0R
        Me.btnPanelUrlEkle.IconVisible = True
        Me.btnPanelUrlEkle.IconZoom = 90.0R
        Me.btnPanelUrlEkle.IsTab = False
        Me.btnPanelUrlEkle.Location = New System.Drawing.Point(1, 442)
        Me.btnPanelUrlEkle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnPanelUrlEkle.Name = "btnPanelUrlEkle"
        Me.btnPanelUrlEkle.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnPanelUrlEkle.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnPanelUrlEkle.OnHoverTextColor = System.Drawing.Color.White
        Me.btnPanelUrlEkle.selected = False
        Me.btnPanelUrlEkle.Size = New System.Drawing.Size(302, 59)
        Me.btnPanelUrlEkle.TabIndex = 2
        Me.btnPanelUrlEkle.TabStop = False
        Me.btnPanelUrlEkle.Text = "               Panel Url Ekle"
        Me.btnPanelUrlEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPanelUrlEkle.Textcolor = System.Drawing.Color.White
        Me.btnPanelUrlEkle.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnTara
        '
        Me.btnTara.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnTara.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnTara.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTara.BorderRadius = 0
        Me.btnTara.ButtonText = "               Tara"
        Me.btnTara.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTara.DisabledColor = System.Drawing.Color.Gray
        Me.btnTara.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnTara.Iconcolor = System.Drawing.Color.Transparent
        Me.btnTara.Iconimage = CType(resources.GetObject("btnTara.Iconimage"), System.Drawing.Image)
        Me.btnTara.Iconimage_right = Nothing
        Me.btnTara.Iconimage_right_Selected = Nothing
        Me.btnTara.Iconimage_Selected = Nothing
        Me.btnTara.IconMarginLeft = 0
        Me.btnTara.IconMarginRight = 0
        Me.btnTara.IconRightVisible = True
        Me.btnTara.IconRightZoom = 0R
        Me.btnTara.IconVisible = True
        Me.btnTara.IconZoom = 90.0R
        Me.btnTara.IsTab = False
        Me.btnTara.Location = New System.Drawing.Point(56, 207)
        Me.btnTara.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnTara.Name = "btnTara"
        Me.btnTara.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnTara.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnTara.OnHoverTextColor = System.Drawing.Color.White
        Me.btnTara.selected = False
        Me.btnTara.Size = New System.Drawing.Size(198, 83)
        Me.btnTara.TabIndex = 0
        Me.btnTara.TabStop = False
        Me.btnTara.Text = "               Tara"
        Me.btnTara.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTara.Textcolor = System.Drawing.Color.White
        Me.btnTara.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        '
        'tbUrl
        '
        Me.tbUrl.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.tbUrl.BackgroundImage = CType(resources.GetObject("tbUrl.BackgroundImage"), System.Drawing.Image)
        Me.tbUrl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tbUrl.Font = New System.Drawing.Font("Consolas", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.tbUrl.ForeColor = System.Drawing.Color.Silver
        Me.tbUrl.Icon = CType(resources.GetObject("tbUrl.Icon"), System.Drawing.Image)
        Me.tbUrl.Location = New System.Drawing.Point(12, 131)
        Me.tbUrl.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbUrl.Name = "tbUrl"
        Me.tbUrl.Size = New System.Drawing.Size(278, 68)
        Me.tbUrl.TabIndex = 1
        Me.tbUrl.TabStop = False
        Me.tbUrl.text = "http://hedefsite.com"
        '
        'pbTurkHacks
        '
        Me.pbTurkHacks.Image = CType(resources.GetObject("pbTurkHacks.Image"), System.Drawing.Image)
        Me.pbTurkHacks.Location = New System.Drawing.Point(18, 18)
        Me.pbTurkHacks.Name = "pbTurkHacks"
        Me.pbTurkHacks.Size = New System.Drawing.Size(272, 93)
        Me.pbTurkHacks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbTurkHacks.TabIndex = 0
        Me.pbTurkHacks.TabStop = False
        '
        'header
        '
        Me.header.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.header.Controls.Add(Me.BunifuCustomLabel6)
        Me.header.Controls.Add(Me.btnKapat)
        Me.header.Controls.Add(Me.PictureBox2)
        Me.header.Controls.Add(Me.BunifuCustomLabel1)
        Me.header.Dock = System.Windows.Forms.DockStyle.Top
        Me.header.Location = New System.Drawing.Point(0, 0)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(1058, 43)
        Me.header.TabIndex = 1
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Consolas", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BunifuCustomLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(558, 23)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(456, 17)
        Me.BunifuCustomLabel6.TabIndex = 4
        Me.BunifuCustomLabel6.Text = "Bu program TurkHacks.com üyeleri tarafından kodlanmıştır"
        '
        'btnKapat
        '
        Me.btnKapat.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnKapat.Image = CType(resources.GetObject("btnKapat.Image"), System.Drawing.Image)
        Me.btnKapat.ImageActive = Nothing
        Me.btnKapat.Location = New System.Drawing.Point(1018, 6)
        Me.btnKapat.Name = "btnKapat"
        Me.btnKapat.Size = New System.Drawing.Size(30, 30)
        Me.btnKapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnKapat.TabIndex = 3
        Me.btnKapat.TabStop = False
        Me.btnKapat.Zoom = 10
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 10)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(28, 23)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(47, 11)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(243, 20)
        Me.BunifuCustomLabel1.TabIndex = 2
        Me.BunifuCustomLabel1.Text = "TRJ - Admin Panel Tarayıcı"
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.header
        Me.BunifuDragControl1.Vertical = True
        '
        'lbPanelUrl
        '
        Me.lbPanelUrl.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.lbPanelUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbPanelUrl.ForeColor = System.Drawing.Color.Gray
        Me.lbPanelUrl.FormattingEnabled = True
        Me.lbPanelUrl.ItemHeight = 16
        Me.lbPanelUrl.Location = New System.Drawing.Point(798, 62)
        Me.lbPanelUrl.Name = "lbPanelUrl"
        Me.lbPanelUrl.Size = New System.Drawing.Size(248, 482)
        Me.lbPanelUrl.TabIndex = 2
        Me.lbPanelUrl.TabStop = False
        '
        'lbBulunan
        '
        Me.lbBulunan.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.lbBulunan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbBulunan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbBulunan.ForeColor = System.Drawing.Color.SeaGreen
        Me.lbBulunan.FormattingEnabled = True
        Me.lbBulunan.ItemHeight = 20
        Me.lbBulunan.Location = New System.Drawing.Point(310, 61)
        Me.lbBulunan.Name = "lbBulunan"
        Me.lbBulunan.Size = New System.Drawing.Size(482, 482)
        Me.lbBulunan.TabIndex = 3
        Me.lbBulunan.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(1375, 76)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(185, 141)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Visible = False
        '
        'ofdDosya
        '
        Me.ofdDosya.FileName = "OpenFileDialog1"
        '
        'tmrTara
        '
        Me.tmrTara.Interval = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(1418, 275)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(169, 133)
        Me.TextBox2.TabIndex = 5
        Me.TextBox2.Visible = False
        Me.TextBox2.WordWrap = False
        '
        'wbUrl
        '
        Me.wbUrl.Location = New System.Drawing.Point(1129, 263)
        Me.wbUrl.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbUrl.Name = "wbUrl"
        Me.wbUrl.Size = New System.Drawing.Size(283, 263)
        Me.wbUrl.TabIndex = 6
        Me.wbUrl.Visible = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(1169, 69)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(200, 148)
        Me.ListBox1.TabIndex = 7
        Me.ListBox1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1058, 557)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.wbUrl)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lbBulunan)
        Me.Controls.Add(Me.lbPanelUrl)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TRJ - Admin Panel Tarayıcı"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.btnKaydet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbTurkHacks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.header.ResumeLayout(False)
        Me.header.PerformLayout()
        CType(Me.btnKapat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pbTurkHacks As PictureBox
    Friend WithEvents header As Panel
    Friend WithEvents btnKapat As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents tbUrl As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents lbPanelUrl As ListBox
    Friend WithEvents btnPanelUrlEkle As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnTara As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents lbBulunan As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblToplamPanelUrl As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblBulunanlar As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblTarananlar As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblRobots As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ofdDosya As OpenFileDialog
    Friend WithEvents tmrTara As Timer
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents wbUrl As WebBrowser
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btnKaydet As Bunifu.Framework.UI.BunifuImageButton
End Class
