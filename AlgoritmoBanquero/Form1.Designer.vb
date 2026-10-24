<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Panel1 = New Panel()
        NumericRecursos = New NumericUpDown()
        NumericProcesos = New NumericUpDown()
        Label4 = New Label()
        btnLimpiar = New Button()
        btnCSV = New Button()
        btnEjemplo = New Button()
        btnGenerar = New Button()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        Label11 = New Label()
        Label10 = New Label()
        Button7 = New Button()
        TextBox1 = New TextBox()
        Label9 = New Label()
        ComboBox1 = New ComboBox()
        Label8 = New Label()
        Button6 = New Button()
        btnNeed = New Button()
        Label7 = New Label()
        tblAvailable = New DataGridView()
        Label6 = New Label()
        Label5 = New Label()
        Label3 = New Label()
        tblNeed = New DataGridView()
        tblMax = New DataGridView()
        tblAllocation = New DataGridView()
        Panel3 = New Panel()
        lblIndicadorDiapositiva = New Label()
        btnSiguiente = New Button()
        btnAnterior = New Button()
        txtTeoria = New RichTextBox()
        txtPasoAPaso = New TextBox()
        Label13 = New Label()
        lblSecuencia = New Label()
        Label12 = New Label()
        lblEstado = New Label()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        Panel1.SuspendLayout()
        CType(NumericRecursos, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericProcesos, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(tblAvailable, ComponentModel.ISupportInitialize).BeginInit()
        CType(tblNeed, ComponentModel.ISupportInitialize).BeginInit()
        CType(tblMax, ComponentModel.ISupportInitialize).BeginInit()
        CType(tblAllocation, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(NumericRecursos)
        Panel1.Controls.Add(NumericProcesos)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(btnLimpiar)
        Panel1.Controls.Add(btnCSV)
        Panel1.Controls.Add(btnEjemplo)
        Panel1.Controls.Add(btnGenerar)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(12, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1351, 81)
        Panel1.TabIndex = 0
        ' 
        ' NumericRecursos
        ' 
        NumericRecursos.Location = New Point(365, 32)
        NumericRecursos.Name = "NumericRecursos"
        NumericRecursos.Size = New Size(90, 27)
        NumericRecursos.TabIndex = 10
        ' 
        ' NumericProcesos
        ' 
        NumericProcesos.Location = New Point(131, 32)
        NumericProcesos.Name = "NumericProcesos"
        NumericProcesos.Size = New Size(90, 27)
        NumericProcesos.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(550, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(164, 62)
        Label4.TabIndex = 8
        Label4.Text = "Algoritmo del" & vbCrLf & "Banquero"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLimpiar.Location = New Point(1247, 29)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(76, 30)
        btnLimpiar.TabIndex = 7
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' btnCSV
        ' 
        btnCSV.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCSV.Location = New Point(1124, 29)
        btnCSV.Name = "btnCSV"
        btnCSV.Size = New Size(103, 30)
        btnCSV.TabIndex = 6
        btnCSV.Text = "Cargar CSV"
        btnCSV.UseVisualStyleBackColor = True
        ' 
        ' btnEjemplo
        ' 
        btnEjemplo.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnEjemplo.Location = New Point(953, 29)
        btnEjemplo.Name = "btnEjemplo"
        btnEjemplo.Size = New Size(165, 30)
        btnEjemplo.TabIndex = 5
        btnEjemplo.Text = "Cargar Ejemplo"
        btnEjemplo.UseVisualStyleBackColor = True
        ' 
        ' btnGenerar
        ' 
        btnGenerar.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnGenerar.Location = New Point(790, 22)
        btnGenerar.Name = "btnGenerar"
        btnGenerar.Size = New Size(157, 40)
        btnGenerar.TabIndex = 4
        btnGenerar.Text = "Generar Tablas"
        btnGenerar.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(244, 32)
        Label2.Name = "Label2"
        Label2.Size = New Size(115, 23)
        Label2.TabIndex = 2
        Label2.Text = "Recursos (M):"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(14, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(111, 23)
        Label1.TabIndex = 0
        Label1.Text = "Procesos (N):"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label11)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(Button7)
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(ComboBox1)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Button6)
        Panel2.Controls.Add(btnNeed)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(tblAvailable)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(tblNeed)
        Panel2.Controls.Add(tblMax)
        Panel2.Controls.Add(tblAllocation)
        Panel2.Location = New Point(18, 89)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1345, 543)
        Panel2.TabIndex = 1
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(720, 381)
        Label11.Name = "Label11"
        Label11.Size = New Size(198, 25)
        Label11.TabIndex = 23
        Label11.Text = "Solicitud de Recursos:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(731, 475)
        Label10.Name = "Label10"
        Label10.Size = New Size(0, 20)
        Label10.TabIndex = 22
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(1176, 471)
        Button7.Name = "Button7"
        Button7.Size = New Size(141, 29)
        Button7.TabIndex = 21
        Button7.Text = "Evaluar Solicitud"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(1004, 416)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(313, 45)
        TextBox1.TabIndex = 18
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(922, 424)
        Label9.Name = "Label9"
        Label9.Size = New Size(66, 23)
        Label9.TabIndex = 17
        Label9.Text = "Pedido:"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(800, 422)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(61, 28)
        ComboBox1.TabIndex = 16
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(720, 424)
        Label8.Name = "Label8"
        Label8.Size = New Size(74, 23)
        Label8.TabIndex = 15
        Label8.Text = "Proceso:"
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(445, 471)
        Button6.Name = "Button6"
        Button6.Size = New Size(250, 29)
        Button6.TabIndex = 14
        Button6.Text = "Ejecutar Algoritmo de Seguridad"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' btnNeed
        ' 
        btnNeed.Location = New Point(445, 432)
        btnNeed.Name = "btnNeed"
        btnNeed.Size = New Size(131, 29)
        btnNeed.TabIndex = 13
        btnNeed.Text = "Calcular Need"
        btnNeed.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(21, 375)
        Label7.Name = "Label7"
        Label7.Size = New Size(205, 25)
        Label7.TabIndex = 12
        Label7.Text = "Available (Disponible):"
        ' 
        ' tblAvailable
        ' 
        tblAvailable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        tblAvailable.Location = New Point(21, 416)
        tblAvailable.Name = "tblAvailable"
        tblAvailable.RowHeadersWidth = 51
        tblAvailable.Size = New Size(402, 107)
        tblAvailable.TabIndex = 11
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(921, 15)
        Label6.Name = "Label6"
        Label6.Size = New Size(221, 25)
        Label6.TabIndex = 10
        Label6.Text = "Need = Max - Allocation"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(471, 15)
        Label5.Name = "Label5"
        Label5.Size = New Size(227, 25)
        Label5.TabIndex = 9
        Label5.Text = "Max (Demanda Maxima):"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(21, 15)
        Label3.Name = "Label3"
        Label3.Size = New Size(217, 25)
        Label3.TabIndex = 8
        Label3.Text = "Allocation (Asignación):"
        ' 
        ' tblNeed
        ' 
        tblNeed.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        tblNeed.Location = New Point(921, 52)
        tblNeed.Name = "tblNeed"
        tblNeed.RowHeadersWidth = 51
        tblNeed.Size = New Size(402, 294)
        tblNeed.TabIndex = 2
        ' 
        ' tblMax
        ' 
        tblMax.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        tblMax.Location = New Point(471, 52)
        tblMax.Name = "tblMax"
        tblMax.RowHeadersWidth = 51
        tblMax.Size = New Size(402, 294)
        tblMax.TabIndex = 1
        ' 
        ' tblAllocation
        ' 
        tblAllocation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        tblAllocation.Location = New Point(21, 52)
        tblAllocation.Name = "tblAllocation"
        tblAllocation.RowHeadersWidth = 51
        tblAllocation.Size = New Size(402, 294)
        tblAllocation.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(lblIndicadorDiapositiva)
        Panel3.Controls.Add(btnSiguiente)
        Panel3.Controls.Add(btnAnterior)
        Panel3.Controls.Add(txtTeoria)
        Panel3.Controls.Add(txtPasoAPaso)
        Panel3.Controls.Add(Label13)
        Panel3.Controls.Add(lblSecuencia)
        Panel3.Controls.Add(Label12)
        Panel3.Controls.Add(lblEstado)
        Panel3.Location = New Point(18, 648)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1345, 313)
        Panel3.TabIndex = 2
        ' 
        ' lblIndicadorDiapositiva
        ' 
        lblIndicadorDiapositiva.AutoSize = True
        lblIndicadorDiapositiva.Location = New Point(947, 272)
        lblIndicadorDiapositiva.Name = "lblIndicadorDiapositiva"
        lblIndicadorDiapositiva.Size = New Size(0, 20)
        lblIndicadorDiapositiva.TabIndex = 13
        ' 
        ' btnSiguiente
        ' 
        btnSiguiente.Location = New Point(1280, 268)
        btnSiguiente.Name = "btnSiguiente"
        btnSiguiente.Size = New Size(43, 29)
        btnSiguiente.TabIndex = 12
        btnSiguiente.Text = "▶"
        btnSiguiente.UseVisualStyleBackColor = True
        ' 
        ' btnAnterior
        ' 
        btnAnterior.Location = New Point(898, 268)
        btnAnterior.Name = "btnAnterior"
        btnAnterior.Size = New Size(43, 29)
        btnAnterior.TabIndex = 11
        btnAnterior.Text = "◀"
        btnAnterior.UseVisualStyleBackColor = True
        ' 
        ' txtTeoria
        ' 
        txtTeoria.Location = New Point(898, 20)
        txtTeoria.Name = "txtTeoria"
        txtTeoria.Size = New Size(425, 242)
        txtTeoria.TabIndex = 10
        txtTeoria.Text = ""
        ' 
        ' txtPasoAPaso
        ' 
        txtPasoAPaso.BackColor = SystemColors.ControlLightLight
        txtPasoAPaso.Location = New Point(382, 58)
        txtPasoAPaso.Multiline = True
        txtPasoAPaso.Name = "txtPasoAPaso"
        txtPasoAPaso.ReadOnly = True
        txtPasoAPaso.ScrollBars = ScrollBars.Vertical
        txtPasoAPaso.Size = New Size(491, 241)
        txtPasoAPaso.TabIndex = 9
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(382, 21)
        Label13.Name = "Label13"
        Label13.Size = New Size(177, 25)
        Label13.TabIndex = 7
        Label13.Text = "Detalle Paso a Paso"
        ' 
        ' lblSecuencia
        ' 
        lblSecuencia.AutoSize = True
        lblSecuencia.Location = New Point(42, 90)
        lblSecuencia.Name = "lblSecuencia"
        lblSecuencia.Size = New Size(0, 20)
        lblSecuencia.TabIndex = 5
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(32, 61)
        Label12.Name = "Label12"
        Label12.Size = New Size(194, 20)
        Label12.TabIndex = 4
        Label12.Text = "Secuencia Segura Sugerida"
        ' 
        ' lblEstado
        ' 
        lblEstado.AutoSize = True
        lblEstado.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEstado.Location = New Point(21, 20)
        lblEstado.Name = "lblEstado"
        lblEstado.Size = New Size(133, 41)
        lblEstado.TabIndex = 3
        lblEstado.Text = "ESTADO"
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(20, 20)
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1375, 983)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(NumericRecursos, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericProcesos, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(tblAvailable, ComponentModel.ISupportInitialize).EndInit()
        CType(tblNeed, ComponentModel.ISupportInitialize).EndInit()
        CType(tblMax, ComponentModel.ISupportInitialize).EndInit()
        CType(tblAllocation, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnCSV As Button
    Friend WithEvents btnEjemplo As Button
    Friend WithEvents btnGenerar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents tblNeed As DataGridView
    Friend WithEvents tblMax As DataGridView
    Friend WithEvents tblAllocation As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnNeed As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents tblAvailable As DataGridView
    Friend WithEvents NumericRecursos As NumericUpDown
    Friend WithEvents NumericProcesos As NumericUpDown
    Friend WithEvents Button6 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblEstado As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblSecuencia As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label13 As Label
    Friend WithEvents txtPasoAPaso As TextBox
    Friend WithEvents txtTeoria As RichTextBox
    Friend WithEvents lblIndicadorDiapositiva As Label
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAnterior As Button

End Class
