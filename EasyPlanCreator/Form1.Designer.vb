Imports System.Xml
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    

    Inherits System.Windows.Forms.Form
    Private Property FromDate As Date = Date.Now
    Private Property ToDate As Date = Date.Now
    Private Property PathVar As String = CurDir()
    Private Property Plan As New Dictionary(Of String, Workoutday)
    Private Property prevSelect As String = "Montag"
    Private Property Export_clicked As Boolean = False



    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lb_TrZeitraum = New System.Windows.Forms.Label()
        Me.dtp_from = New System.Windows.Forms.DateTimePicker()
        Me.dtp_to = New System.Windows.Forms.DateTimePicker()
        Me.lb_from = New System.Windows.Forms.Label()
        Me.lb_to = New System.Windows.Forms.Label()
        Me.lb_Trainigstag = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FAQToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmb_Day = New System.Windows.Forms.ComboBox()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.btn_export = New System.Windows.Forms.Button()
        Me.dgv_Units = New System.Windows.Forms.DataGridView()
        Me.col_Unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_reps = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_weight = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_issuperset = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.col_istrset = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.col_info = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExporttoXML = New System.Windows.Forms.SaveFileDialog()
        Me.XMLImportierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgv_Units, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lb_TrZeitraum
        '
        Me.lb_TrZeitraum.AutoSize = True
        Me.lb_TrZeitraum.Location = New System.Drawing.Point(8, 30)
        Me.lb_TrZeitraum.Name = "lb_TrZeitraum"
        Me.lb_TrZeitraum.Size = New System.Drawing.Size(92, 13)
        Me.lb_TrZeitraum.TabIndex = 0
        Me.lb_TrZeitraum.Text = "Trainingszeitraum:"
        '
        'dtp_from
        '
        Me.dtp_from.Location = New System.Drawing.Point(53, 46)
        Me.dtp_from.Name = "dtp_from"
        Me.dtp_from.Size = New System.Drawing.Size(200, 20)
        Me.dtp_from.TabIndex = 1
        '
        'dtp_to
        '
        Me.dtp_to.Location = New System.Drawing.Point(315, 40)
        Me.dtp_to.Name = "dtp_to"
        Me.dtp_to.Size = New System.Drawing.Size(200, 20)
        Me.dtp_to.TabIndex = 2
        '
        'lb_from
        '
        Me.lb_from.AutoSize = True
        Me.lb_from.Location = New System.Drawing.Point(11, 52)
        Me.lb_from.Name = "lb_from"
        Me.lb_from.Size = New System.Drawing.Size(32, 13)
        Me.lb_from.TabIndex = 3
        Me.lb_from.Text = "Von: "
        '
        'lb_to
        '
        Me.lb_to.AutoSize = True
        Me.lb_to.Location = New System.Drawing.Point(277, 46)
        Me.lb_to.Name = "lb_to"
        Me.lb_to.Size = New System.Drawing.Size(27, 13)
        Me.lb_to.TabIndex = 4
        Me.lb_to.Text = "Bis: "
        '
        'lb_Trainigstag
        '
        Me.lb_Trainigstag.AutoSize = True
        Me.lb_Trainigstag.Location = New System.Drawing.Point(18, 84)
        Me.lb_Trainigstag.Name = "lb_Trainigstag"
        Me.lb_Trainigstag.Size = New System.Drawing.Size(65, 13)
        Me.lb_Trainigstag.TabIndex = 5
        Me.lb_Trainigstag.Text = "Trainingstag"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem, Me.InfoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(547, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.XMLImportierenToolStripMenuItem, Me.BeendenToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem.Text = "Datei"
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.BeendenToolStripMenuItem.Text = "Beenden"
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.FAQToolStripMenuItem})
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.InfoToolStripMenuItem.Text = "Info"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'FAQToolStripMenuItem
        '
        Me.FAQToolStripMenuItem.Name = "FAQToolStripMenuItem"
        Me.FAQToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.FAQToolStripMenuItem.Text = "FAQ"
        '
        'cmb_Day
        '
        Me.cmb_Day.FormattingEnabled = True
        Me.cmb_Day.Location = New System.Drawing.Point(21, 100)
        Me.cmb_Day.Name = "cmb_Day"
        Me.cmb_Day.Size = New System.Drawing.Size(121, 21)
        Me.cmb_Day.TabIndex = 21
        '
        'btn_close
        '
        Me.btn_close.Location = New System.Drawing.Point(440, 622)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(75, 23)
        Me.btn_close.TabIndex = 22
        Me.btn_close.Text = "Abbrechen"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'btn_export
        '
        Me.btn_export.Location = New System.Drawing.Point(352, 622)
        Me.btn_export.Name = "btn_export"
        Me.btn_export.Size = New System.Drawing.Size(75, 23)
        Me.btn_export.TabIndex = 23
        Me.btn_export.Text = "Exportieren"
        Me.btn_export.UseVisualStyleBackColor = True
        '
        'dgv_Units
        '
        Me.dgv_Units.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Units.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_Units.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Units.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_Unit, Me.col_reps, Me.col_weight, Me.col_issuperset, Me.col_istrset, Me.col_info})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Units.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_Units.Location = New System.Drawing.Point(21, 127)
        Me.dgv_Units.Name = "dgv_Units"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Units.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_Units.Size = New System.Drawing.Size(494, 489)
        Me.dgv_Units.TabIndex = 24
        '
        'col_Unit
        '
        Me.col_Unit.HeaderText = "Einheit"
        Me.col_Unit.Name = "col_Unit"
        Me.col_Unit.ToolTipText = "Name der Übung eintragen"
        '
        'col_reps
        '
        Me.col_reps.HeaderText = "Wiederholungen"
        Me.col_reps.Name = "col_reps"
        Me.col_reps.ToolTipText = "Anzahl der WIederholungen eingeben (SxR)"
        '
        'col_weight
        '
        Me.col_weight.HeaderText = "Gewicht"
        Me.col_weight.Name = "col_weight"
        Me.col_weight.ToolTipText = "Gewicht eintragen"
        Me.col_weight.Width = 50
        '
        'col_issuperset
        '
        Me.col_issuperset.HeaderText = "Supersatz"
        Me.col_issuperset.Name = "col_issuperset"
        Me.col_issuperset.Width = 50
        '
        'col_istrset
        '
        Me.col_istrset.HeaderText = "Dreisatz"
        Me.col_istrset.Name = "col_istrset"
        Me.col_istrset.Width = 50
        '
        'col_info
        '
        Me.col_info.HeaderText = "Info"
        Me.col_info.Name = "col_info"
        Me.col_info.ToolTipText = "Zusätzliche informationen"
        '
        'ExporttoXML
        '
        Me.ExporttoXML.DefaultExt = "xml"
        Me.ExporttoXML.FileName = "Plan.xml"
        Me.ExporttoXML.Filter = "(*.xml)|*.xml"
        '
        'XMLImportierenToolStripMenuItem
        '
        Me.XMLImportierenToolStripMenuItem.Name = "XMLImportierenToolStripMenuItem"
        Me.XMLImportierenToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.XMLImportierenToolStripMenuItem.Text = "XML Importieren"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 662)
        Me.Controls.Add(Me.dgv_Units)
        Me.Controls.Add(Me.btn_export)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.cmb_Day)
        Me.Controls.Add(Me.lb_Trainigstag)
        Me.Controls.Add(Me.lb_to)
        Me.Controls.Add(Me.lb_from)
        Me.Controls.Add(Me.dtp_to)
        Me.Controls.Add(Me.dtp_from)
        Me.Controls.Add(Me.lb_TrZeitraum)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgv_Units, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lb_TrZeitraum As Label
    Friend WithEvents dtp_from As DateTimePicker
    Friend WithEvents dtp_to As DateTimePicker
    Friend WithEvents lb_from As Label
    Friend WithEvents lb_to As Label
    Friend WithEvents lb_Trainigstag As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DateiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmb_Day As ComboBox
    Friend WithEvents btn_close As Button
    Friend WithEvents btn_export As Button





    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FAQToolStripMenuItem As ToolStripMenuItem



    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Dim result As DialogResult = MessageBox.Show("Easy Plan Creator Beenden?", "Warnung", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If result = DialogResult.OK Then
            Me.Close()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmb_Day.Items.Add("Montag")
        cmb_Day.Items.Add("Dienstag")
        cmb_Day.Items.Add("Mittwoch")
        cmb_Day.Items.Add("Donnerstag")
        cmb_Day.Items.Add("Freitag")
        cmb_Day.Items.Add("Samstag")
        cmb_Day.Items.Add("Sonntag")

        cmb_Day.SelectedItem = cmb_Day.Items(0)

    End Sub


    Friend WithEvents dgv_Units As DataGridView

    Private Sub btn_export_Click(sender As Object, e As EventArgs) Handles btn_export.Click
        Export_clicked = True
        getDatagrid()

        Dim result As DialogResult = ExporttoXML.ShowDialog()

        If result = DialogResult.OK Then
            PathVar = ExporttoXML.FileName
            parsexml()
        End If
        Dim res As DialogResult = MessageBox.Show("Export erfolgreich, Programm verlassen?", "Erfolg", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If res = DialogResult.Yes Then
            Me.Close()
        Else
            Export_clicked = False
            getDatagrid()

        End If

    End Sub

    Private Sub cmb_Day_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Day.SelectedIndexChanged

        getDatagrid()

    End Sub

    Private Sub getDatagrid()
        dgv_Units.AllowUserToAddRows = False
        If dgv_Units.IsCurrentRowDirty Then

            dgv_Units.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If

        Dim ListofUnits As New List(Of WorkoutUnit)




        If dgv_Units.CurrentCell IsNot Nothing Then

            If Plan.ContainsKey(prevSelect) Then
                Plan.Remove(prevSelect)
            End If
            For Each Row As DataGridViewRow In dgv_Units.Rows
                If Row.Cells(0).Value IsNot Nothing Then


                    ListofUnits.Add(New WorkoutUnit(Row.Cells(0).Value, Row.Cells(1).Value, Row.Cells(2).Value, Row.Cells(5).Value, Row.Cells(3).Value, Row.Cells(4).Value))
                End If
            Next
            Plan.Add(prevSelect, New Workoutday(prevSelect, ListofUnits))

        End If


        prevSelect = cmb_Day.SelectedItem

        If Export_clicked = False Then
            refillDataGrid()
        End If


        dgv_Units.AllowUserToAddRows = True

    End Sub

    Private Sub ExportGrid()

    End Sub


    Private Sub fillDataGrid()


    End Sub

    Private Sub dgv_Units_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Units.CellContentClick

    End Sub
    Private Sub CellValueChanged(ByVal sender As Object,
        ByVal e As DataGridViewCellEventArgs) _
        Handles dgv_Units.CellValueChanged
        If dgv_Units.IsCurrentCellDirty Then
            dgv_Units.EndEdit()
            dgv_Units.CommitEdit(DataGridViewDataErrorContexts.CurrentCellChange)
        End If
    End Sub

    Public Sub refillDataGrid()

        dgv_Units.Rows.Clear()

        If Plan.ContainsKey(prevSelect) Then
            Dim currow As Integer = 0
            Dim tmpLoU As List(Of WorkoutUnit)
            tmpLoU = Plan(prevSelect).Units

            For Each element As WorkoutUnit In tmpLoU

                dgv_Units.Rows.Add()
                dgv_Units.Rows(currow).Cells(0).Value = element.Name
                dgv_Units.Rows(currow).Cells(1).Value = element.Reps
                dgv_Units.Rows(currow).Cells(2).Value = element.Weight
                dgv_Units.Rows(currow).Cells(3).Value = element.isSprset
                dgv_Units.Rows(currow).Cells(4).Value = element.isTrset
                dgv_Units.Rows(currow).Cells(5).Value = element.Info
                currow += 1
            Next


            Plan.Remove(prevSelect)
        End If


    End Sub




    Friend WithEvents col_Unit As DataGridViewTextBoxColumn
    Friend WithEvents col_reps As DataGridViewTextBoxColumn
    Friend WithEvents col_weight As DataGridViewTextBoxColumn
    Friend WithEvents col_issuperset As DataGridViewCheckBoxColumn
    Friend WithEvents col_istrset As DataGridViewCheckBoxColumn
    Friend WithEvents col_info As DataGridViewTextBoxColumn
    Friend WithEvents BeendenToolStripMenuItem As ToolStripMenuItem

    Private Sub BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeendenToolStripMenuItem.Click

        Dim result As DialogResult = MessageBox.Show("Easy Plan Creator Beenden?", "Warnung", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If result = DialogResult.OK Then
            Me.Close()
        End If

    End Sub
    Friend WithEvents ExporttoXML As SaveFileDialog

    Private Sub ExporttoXML_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ExporttoXML.FileOk

    End Sub

    Private Sub parsexml()
        Try


            Dim parser As New XmlTextWriter(PathVar, System.Text.Encoding.UTF8)
            parser.WriteStartDocument(True)
            parser.Formatting = Formatting.Indented
            parser.Indentation = 2

            parser.WriteStartElement("Plan")

            'Start Intervall section
            parser.WriteStartElement("Intervall")
            parser.WriteStartElement("From")
            parser.WriteString(FromDate.ToString)
            parser.WriteEndElement()
            parser.WriteStartElement("To")
            parser.WriteString(ToDate.ToString)
            parser.WriteEndElement()
            parser.WriteEndElement()
            'End Intervall

            For Each KP As KeyValuePair(Of String, Workoutday) In Plan

                parser.WriteStartElement(KP.Key)

                For Each LU As WorkoutUnit In KP.Value.Units

                    parser.WriteStartElement(LU.Name)
                    parser.WriteStartElement("Reps")
                    parser.WriteString(LU.Reps)
                    parser.WriteEndElement()
                    parser.WriteStartElement("Weight")
                    parser.WriteString(LU.Weight)
                    parser.WriteEndElement()
                    parser.WriteStartElement("isSprset")
                    parser.WriteString(LU.isSprset.ToString)
                    parser.WriteEndElement()
                    parser.WriteStartElement("isTrset")
                    parser.WriteString(LU.isTrset.ToString)
                    parser.WriteEndElement()
                    If LU.Info <> Nothing Then
                        parser.WriteStartElement("info")
                        parser.WriteString(LU.Info)
                        parser.WriteEndElement()
                    Else
                        parser.WriteStartElement("info")
                        parser.WriteString("")
                        parser.WriteEndElement()
                    End If

                    parser.WriteEndElement()

                Next
                parser.WriteEndElement()



            Next

            parser.WriteEndElement()
            parser.WriteEndDocument()
            parser.Close()


        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub dtp_from_ValueChanged(sender As Object, e As EventArgs) Handles dtp_from.ValueChanged

    End Sub

    Private Sub dtp_to_ValueChanged(sender As Object, e As EventArgs) Handles dtp_to.ValueChanged

    End Sub

    Friend WithEvents XMLImportierenToolStripMenuItem As ToolStripMenuItem
End Class


