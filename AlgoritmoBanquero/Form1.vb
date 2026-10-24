Public Class Form1
    Private ejemploInseguroActual As Boolean = False

    Private diapositivaActual As Integer = 0
    Private paginasTeoria As List(Of String)
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub NumericProcesos_ValueChanged(sender As Object, e As EventArgs) Handles NumericProcesos.ValueChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inicializar la lista de diapositivas de forma segura y sin errores de sintaxis
        paginasTeoria = New List(Of String)()

        Dim pagina1 As String = "🔣 ¿QUÉ ES EL ALGORITMO DEL BANQUERO?" & Environment.NewLine & Environment.NewLine &
                                "Es un algoritmo de prevención de interbloqueos (deadlocks) desarrollado por Edsger Dijkstra." & Environment.NewLine & Environment.NewLine &
                                "Simula las asignaciones de recursos de un sistema operativo a los procesos de forma segura, garantizando que nunca se alcance un estado inseguro."
        paginasTeoria.Add(pagina1)

        Dim pagina2 As String = "⚙️ ¿CÓMO FUNCIONA?" & Environment.NewLine & Environment.NewLine &
                                "1. Calcula los recursos que necesita cada proceso." & Environment.NewLine &
                                "2. Busca un proceso cuyas necesidades puedan cubrirse con los recursos disponibles." & Environment.NewLine &
                                "3. Simula su finalización y libera sus recursos asignados." & Environment.NewLine &
                                "4. Repite el proceso hasta terminar todos los procesos o determinar que no existe una secuencia segura."
        paginasTeoria.Add(pagina2)

        Dim pagina3 As String = "⏹️ TABLAS DE RECURSOS" & Environment.NewLine & Environment.NewLine &
                                "• Allocation — Recursos asignados: Recursos que cada proceso tiene actualmente." & Environment.NewLine &
                                "• Max — Demanda máxima: Máximo de recursos que cada proceso podría necesitar." & Environment.NewLine &
                                "• Need — Recursos restantes: Recursos adicionales que cada proceso necesita para finalizar." & Environment.NewLine &
                                "• Available — Recursos disponibles: Cantidad de recursos libres en el sistema."
        paginasTeoria.Add(pagina3)

        Dim pagina4 As String = "🔢 FÓRMULAS MATEMÁTICAS" & Environment.NewLine & Environment.NewLine &
                                "Necesidad restante" & Environment.NewLine &
                                "Need = Max - Allocation" & Environment.NewLine & Environment.NewLine &
                                "Verificación de recursos" & Environment.NewLine &
                                "Needᵢ ≤ Work" & Environment.NewLine & Environment.NewLine &
                                "Liberación al finalizar" & Environment.NewLine &
                                "Work = Work + Allocationᵢ" & Environment.NewLine &
                                "Inicialmente, Work = Available."
        paginasTeoria.Add(pagina4)

        Dim pagina5 As String = "✅ RESOLUCIÓN PASO A PASO" & Environment.NewLine & Environment.NewLine &
                                "1. Calcular la matriz Need." & Environment.NewLine &
                                "2. Inicializar Work con Available." & Environment.NewLine &
                                "3. Buscar un proceso pendiente con Need ≤ Work." & Environment.NewLine &
                                "4. Registrar el proceso en la secuencia segura y actualizar Work liberando su Allocation." & Environment.NewLine &
                                "5. Repetir. Si todos terminan, el estado es seguro; si ninguno puede avanzar, es inseguro."
        paginasTeoria.Add(pagina5)

        Dim pagina6 As String = "📝 SOLICITUD DE RECURSOS" & Environment.NewLine & Environment.NewLine &
                                "Cuando un proceso solicita recursos, el algoritmo verifica que la solicitud no supere su Need ni los recursos Available. Luego simula la asignación y comprueba si el sistema permanece en un estado seguro." & Environment.NewLine & Environment.NewLine &
                                "Condiciones:" & Environment.NewLine &
                                "Requestᵢ ≤ Needᵢ" & Environment.NewLine &
                                "Requestᵢ ≤ Available" & Environment.NewLine & Environment.NewLine &
                                "Si ambas se cumplen, se evalúa la seguridad del sistema. La solicitud se concede únicamente si el estado resultante es seguro; de lo contrario, el proceso debe esperar."
        paginasTeoria.Add(pagina6)

        ActualizarDiapositiva()
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If diapositivaActual < paginasTeoria.Count - 1 Then
            diapositivaActual += 1
            ActualizarDiapositiva()
        End If
    End Sub

    ' Botón: Diapositiva Anterior
    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        If diapositivaActual > 0 Then
            diapositivaActual -= 1
            ActualizarDiapositiva()
        End If
    End Sub

    Private Sub ActualizarDiapositiva()
        ' Muestra únicamente el texto de la teoría actual en el RichTextBox
        txtTeoria.Text = paginasTeoria(diapositivaActual)

        ' Actualiza el indicador visual de la página (ej: 1 / 3)
        lblIndicadorDiapositiva.Text = $"{diapositivaActual + 1} / {paginasTeoria.Count}"

        ' Controla el estado de los botones de navegación
        btnAnterior.Enabled = (diapositivaActual > 0)
        btnSiguiente.Enabled = (diapositivaActual < paginasTeoria.Count - 1)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnEjemplo.Click
        Dim n As Integer
        Dim m As Integer
        Dim allocData(,) As Integer
        Dim maxData(,) As Integer
        Dim availData() As Integer

        If Not ejemploInseguroActual Then

            ' EJEMPLO 1: ESTADO SEGURO
            n = 4
            m = 3

            allocData = New Integer(,) {
            {1, 0, 1},
            {1, 2, 0},
            {1, 1, 1},
            {0, 1, 2}
        }

            maxData = New Integer(,) {
            {2, 1, 2},
            {2, 3, 1},
            {3, 2, 2},
            {1, 1, 3}
        }

            availData = New Integer() {1, 0, 1}

            ejemploInseguroActual = True
            btnEjemplo.Text = "Ejemplo inseguro"

        Else

            ' EJEMPLO 2: ESTADO INSEGURO
            n = 3
            m = 2

            allocData = New Integer(,) {
            {1, 0},
            {0, 1},
            {1, 1}
        }

            maxData = New Integer(,) {
            {2, 2},
            {1, 3},
            {3, 2}
        }

            availData = New Integer() {1, 0}

            ejemploInseguroActual = False
            btnEjemplo.Text = "Ejemplo seguro"

        End If

        ' Actualizar cantidad de procesos y recursos
        NumericProcesos.Value = n
        NumericRecursos.Value = m

        ' Crear las tablas con las nuevas dimensiones
        ConfigurarDataGridViews(n, m)

        ' Cargar Allocation y Max
        For i As Integer = 0 To n - 1
            For j As Integer = 0 To m - 1

                tblAllocation.Rows(i).Cells(j + 1).Value =
                allocData(i, j)

                tblMax.Rows(i).Cells(j + 1).Value =
                maxData(i, j)

                ' Calcular Need = Max - Allocation
                tblNeed.Rows(i).Cells(j + 1).Value =
                maxData(i, j) - allocData(i, j)

            Next
        Next

        ' Cargar Available
        For j As Integer = 0 To m - 1
            tblAvailable.Rows(0).Cells(j).Value = availData(j)
        Next

        ' Limpiar resultados anteriores
        txtPasoAPaso.Clear()
        lblSecuencia.Text = ""
        lblEstado.Text = "ESTADO PENDIENTE"
        lblEstado.ForeColor = Color.Gray

        Label10.Text = ""
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Dim n As Integer = CInt(NumericProcesos.Value)
        Dim m As Integer = CInt(NumericRecursos.Value)

        ConfigurarDataGridViews(n, m)
    End Sub

    Private Sub ConfigurarDataGridViews(n As Integer, m As Integer)
        tblAllocation.AllowUserToAddRows = False
        tblMax.AllowUserToAddRows = False
        tblNeed.AllowUserToAddRows = False
        tblAvailable.AllowUserToAddRows = False

        ' Limpiar columnas previas
        tblAllocation.Columns.Clear()
        tblMax.Columns.Clear()
        tblNeed.Columns.Clear()
        tblAvailable.Columns.Clear()

        ' Agregar columna de Procesos a las matrices principales
        tblAllocation.Columns.Add("Proceso", "Proceso")
        tblMax.Columns.Add("Proceso", "Proceso")
        tblNeed.Columns.Add("Proceso", "Proceso")

        ' Agregar columnas de recursos (A, B, C...) dinámicamente
        For j As Integer = 0 To m - 1
            Dim nombreRecurso As String = Chr(65 + j) ' A, B, C, ...
            tblAllocation.Columns.Add("ColAlloc_" & j, nombreRecurso)
            tblMax.Columns.Add("ColMax_" & j, nombreRecurso)
            tblNeed.Columns.Add("ColNeed_" & j, nombreRecurso)
            tblAvailable.Columns.Add("ColAvail_" & j, nombreRecurso)
        Next

        ' Agregar filas para los N procesos
        tblAllocation.Rows.Add(n)
        tblMax.Rows.Add(n)
        tblNeed.Rows.Add(n)

        For i As Integer = 0 To n - 1
            tblAllocation.Rows(i).Cells("Proceso").Value = "P" & i
            tblMax.Rows(i).Cells("Proceso").Value = "P" & i
            tblNeed.Rows(i).Cells("Proceso").Value = "P" & i
        Next

        ' Agregar una fila para Available (1 x M)
        tblAvailable.Rows.Add(1)

        ' Llenar selector con los procesos disponibles para la solicitud
        ComboBox1.Items.Clear()
        For i As Integer = 0 To n - 1
            ComboBox1.Items.Add("P" & i)
        Next
        If ComboBox1.Items.Count > 0 Then ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        ' Limpiar las tablas
        tblAllocation.Columns.Clear()
        tblMax.Columns.Clear()
        tblNeed.Columns.Clear()
        tblAvailable.Columns.Clear()

        ' Reiniciar los NumericUpDown
        NumericProcesos.Value = 0
        NumericRecursos.Value = 0

        ' Limpiar el ComboBox y dejar P0 seleccionado
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("P0")
        ComboBox1.SelectedIndex = 0

        ' Limpiar el TextBox de solicitud
        TextBox1.Clear()

        ' Limpiar los resultados y mensajes
        txtPasoAPaso.Clear()
        lblSecuencia.Text = ""
        Label10.Text = ""

        ' Restablecer el estado
        lblEstado.Text = "ESTADO PENDIENTE"
        lblEstado.ForeColor = Color.Gray

        ' Reiniciar el botón de ejemplos
        ejemploInseguroActual = False
        btnEjemplo.Text = "Ejemplo"
    End Sub

    Private Sub btnNeed_Click(sender As Object, e As EventArgs) Handles btnNeed.Click
        Try
            Dim n As Integer = tblAllocation.Rows.Count
            Dim m As Integer = tblAllocation.Columns.Count - 1

            For i As Integer = 0 To n - 1
                For j As Integer = 0 To m - 1
                    Dim maxVal As Integer = CInt(tblMax.Rows(i).Cells(j + 1).Value)
                    Dim allocVal As Integer = CInt(tblAllocation.Rows(i).Cells(j + 1).Value)

                    ' Validación básica
                    If maxVal < 0 OrElse allocVal < 0 Then
                        MessageBox.Show("No se permiten valores negativos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If

                    If allocVal > maxVal Then
                        MessageBox.Show($"Error en P{i}: Allocation no puede ser mayor que Max.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If

                    ' Cálculo de Need
                    tblNeed.Rows(i).Cells(j + 1).Value = maxVal - allocVal
                Next
            Next
            MessageBox.Show("Matriz Need calculada exitosamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Por favor, asegúrese de generar las tablas y rellenar todos los campos numéricos correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        txtPasoAPaso.Clear()
        Try
            Dim n As Integer = CInt(NumericProcesos.Value)
            Dim m As Integer = tblAllocation.Columns.Count - 1 ' o similar, calculando según columnas de recursos

            ' Asegurar que m se obtenga bien
            m = tblAllocation.Columns.Count - 1

            Dim allocation(n - 1, m - 1) As Integer
            Dim need(n - 1, m - 1) As Integer
            Dim available(m - 1) As Integer

            ' Leer datos desde los DataGridViews

            For i As Integer = 0 To n - 1
                For j As Integer = 0 To m - 1

                    allocation(i, j) =
            CInt(tblAllocation.Rows(i).Cells(j + 1).Value)

                    Dim maxVal As Integer =
            CInt(tblMax.Rows(i).Cells(j + 1).Value)

                    need(i, j) = maxVal - allocation(i, j)

                    If allocation(i, j) < 0 OrElse maxVal < 0 _
            OrElse allocation(i, j) > maxVal Then

                        MessageBox.Show(
                "Datos inválidos en el proceso P" & i &
                ". Verifique Allocation y Max.",
                "Error de validación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)
                        Return
                    End If

                    ' Mantener la matriz Need visible actualizada
                    tblNeed.Rows(i).Cells(j + 1).Value = need(i, j)

                Next
            Next


            For j As Integer = 0 To m - 1
                available(j) = CInt(tblAvailable.Rows(0).Cells(j).Value)
            Next

            ' Ejecutar función de seguridad
            Dim secuencia As New List(Of String)()
            Dim esSeguro As Boolean = EvaluarSeguridad(n, m, available, allocation, need, secuencia)

            If esSeguro Then
                lblEstado.Text = "ESTADO SEGURO"
                lblEstado.ForeColor = Color.Green
                lblSecuencia.Text = String.Join(" -> ", secuencia)
            Else
                lblEstado.Text = "ESTADO INSEGURO"
                lblEstado.ForeColor = Color.Red
                lblSecuencia.Text = "No hay secuencia segura"
            End If

        Catch ex As Exception
            MessageBox.Show("Error al ejecutar el algoritmo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Función lógica del Algoritmo de Seguridad con la estructura de logs solicitada
    Private Function EvaluarSeguridad(n As Integer, m As Integer, available() As Integer, allocation(,) As Integer, need(,) As Integer, ByRef secuencia As List(Of String)) As Boolean
        Dim work(m - 1) As Integer
        Array.Copy(available, work, m)

        Dim finish(n - 1) As Boolean

        For i As Integer = 0 To n - 1
            finish(i) = False
        Next

        secuencia.Clear()

        txtPasoAPaso.AppendText(
        "Inicio: Work = Available = [" &
        String.Join(", ", work) & "]" &
        Environment.NewLine
    )

        Dim iteracion As Integer = 1
        Dim procesosTerminados As Integer = 0

        While procesosTerminados < n

            txtPasoAPaso.AppendText(
            Environment.NewLine &
            "Iteración " & iteracion &
            " | Work = [" & String.Join(", ", work) & "]" &
            Environment.NewLine
        )

            Dim encontrado As Boolean = False

            ' Buscar un solo proceso que pueda terminar
            For i As Integer = 0 To n - 1

                If finish(i) Then
                    Continue For
                End If

                Dim puedeEjecutarse As Boolean = True

                For j As Integer = 0 To m - 1
                    If need(i, j) > work(j) Then
                        puedeEjecutarse = False
                        Exit For
                    End If
                Next

                If Not puedeEjecutarse Then

                    txtPasoAPaso.AppendText(
                    "P" & i & ": no puede ejecutarse." &
                    " Need = [" &
                    String.Join(", ",
                        Enumerable.Range(0, m).
                        Select(Function(j) need(i, j))) &
                    "] > Work" &
                    Environment.NewLine
                )

                    Continue For

                End If

                ' Mostrar que el proceso sí puede ejecutarse
                txtPasoAPaso.AppendText(
                "P" & i & ": puede ejecutarse." &
                Environment.NewLine
            )

                txtPasoAPaso.AppendText(
                "Need = [" &
                String.Join(", ",
                    Enumerable.Range(0, m).
                    Select(Function(j) need(i, j))) &
                "] <= Work = [" &
                String.Join(", ", work) & "]" &
                Environment.NewLine
            )

                ' El proceso termina y libera sus recursos
                For j As Integer = 0 To m - 1
                    work(j) += allocation(i, j)
                Next

                finish(i) = True
                secuencia.Add("P" & i)
                procesosTerminados += 1
                encontrado = True

                txtPasoAPaso.AppendText(
                "P" & i & " termina. Libera Allocation = [" &
                String.Join(", ",
                    Enumerable.Range(0, m).
                    Select(Function(j) allocation(i, j))) &
                "]" & Environment.NewLine
            )

                txtPasoAPaso.AppendText(
                "New Work = [" &
                String.Join(", ", work) & "]" &
                Environment.NewLine
            )

                ' Solo un proceso por iteración
                Exit For

            Next

            ' Ningún proceso pendiente pudo terminar
            If Not encontrado Then

                txtPasoAPaso.AppendText(
                Environment.NewLine &
                "No se encontró ningún proceso que pueda ejecutarse." &
                Environment.NewLine &
                "El sistema se encuentra en ESTADO INSEGURO." &
                Environment.NewLine
            )

                Return False

            End If

            iteracion += 1

        End While

        txtPasoAPaso.AppendText(
        Environment.NewLine &
        "El sistema se encuentra en ESTADO SEGURO." &
        Environment.NewLine &
        "Secuencia segura: " &
        String.Join(" -> ", secuencia) &
        Environment.NewLine
    )

        Return True

    End Function

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            If ComboBox1.SelectedItem Is Nothing Then
                MessageBox.Show("Seleccione un proceso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim procesoStr As String = ComboBox1.SelectedItem.ToString()
            Dim dataProcesoIndex As Integer = CInt(procesoStr.Replace("P", ""))

            Dim n As Integer = tblAllocation.Rows.Count
            Dim m As Integer = tblAllocation.Columns.Count - 1

            ' 1. Leer y separar el texto del pedido usando el guión como separador
            Dim textoInput As String = TextBox1.Text.Trim()
            If String.IsNullOrEmpty(textoInput) Then
                Label10.Text = "Error: Ingrese los recursos separados por guiones (ej. 1-0-2)."
                Label10.ForeColor = Color.Red
                Return
            End If

            Dim partes() As String = textoInput.Split("-"c)

            ' Validar que la cantidad de recursos ingresados coincida con M
            If partes.Length <> m Then
                Label10.Text = $"Error: Debe ingresar exactamente {m} valores separados por guión."
                Label10.ForeColor = Color.Red
                Return
            End If

            Dim request(m - 1) As Integer
            For j As Integer = 0 To m - 1
                request(j) = CInt(partes(j).Trim())
            Next

            ' 2. Leer matrices actuales desde la interfaz
            Dim allocation(n - 1, m - 1) As Integer
            Dim need(n - 1, m - 1) As Integer
            Dim available(m - 1) As Integer

            For i As Integer = 0 To n - 1
                For j As Integer = 0 To m - 1
                    allocation(i, j) = CInt(tblAllocation.Rows(i).Cells(j + 1).Value)
                    need(i, j) = CInt(tblNeed.Rows(i).Cells(j + 1).Value)
                Next
            Next

            For j As Integer = 0 To m - 1
                available(j) = CInt(tblAvailable.Rows(0).Cells(j).Value)
            Next

            ' 3. Validar que el pedido <= Need[i]

            For j As Integer = 0 To m - 1
                If request(j) < 0 Then
                    Label10.Text = "Error: no se permiten solicitudes negativas."
                    Label10.ForeColor = Color.Red
                    Return
                End If
            Next

            For j As Integer = 0 To m - 1
                request(j) = CInt(partes(j).Trim())
            Next

            ' 4. Validar que el pedido <= Available
            For j As Integer = 0 To m - 1
                If request(j) > available(j) Then
                    Label10.Text = "El proceso debe esperar: los recursos solicitados exceden los disponibles."
                    Label10.ForeColor = Color.DarkOrange
                    Return
                End If
            Next

            ' 5. Simular asignación de prueba
            For j As Integer = 0 To m - 1
                available(j) -= request(j)
                allocation(dataProcesoIndex, j) += request(j)
                need(dataProcesoIndex, j) -= request(j)
            Next


            ' 6. Evaluar si el sistema sigue en estado seguro
            Dim secuenciaSimulada As New List(Of String)()
            Dim esSeguro As Boolean = EvaluarSeguridad(
                n, m, available, allocation, need, secuenciaSimulada)

            If esSeguro Then

                ' Confirmar la asignación en las tablas
                For j As Integer = 0 To m - 1
                    tblAvailable.Rows(0).Cells(j).Value = available(j)

                    tblAllocation.Rows(dataProcesoIndex).Cells(j + 1).Value =
                        allocation(dataProcesoIndex, j)

                    tblNeed.Rows(dataProcesoIndex).Cells(j + 1).Value =
                        need(dataProcesoIndex, j)
                Next

                Label10.Text =
                    "Solicitud concedida: el sistema permanece en estado seguro."
                Label10.ForeColor = Color.Green

                lblSecuencia.Text = String.Join(" -> ", secuenciaSimulada)
                lblEstado.Text = "ESTADO SEGURO"
                lblEstado.ForeColor = Color.Green

            Else
                ' No modificar las tablas: la solicitud se rechaza
                Label10.Text =
                    "Solicitud denegada: llevaría al sistema a un estado inseguro."
                Label10.ForeColor = Color.Red

                lblEstado.Text = "ESTADO INSEGURO"
                lblEstado.ForeColor = Color.Red

                lblSecuencia.Text = "No hay secuencia segura"
            End If


        Catch ex As Exception
            MessageBox.Show("Verifique el formato ingresado. Use números enteros separados por guiones (ej: 1-0-2).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub btnCSV_Click(sender As Object, e As EventArgs) Handles btnCSV.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Archivos CSV (*.csv)|*.csv|Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
            openFileDialog.Title = "Seleccionar archivo CSV del Algoritmo del Banquero"

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Try
                    Dim lineas() As String = IO.File.ReadAllLines(openFileDialog.FileName)

                    If lineas.Length < 3 Then
                        MessageBox.Show("El formato del archivo CSV no es válido. Debe contener al menos la configuración, Allocation y Max.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If

                    ' 1. Leer la primera línea con N (procesos) y M (recursos) - Ejemplo: 5,3
                    Dim config() As String = lineas(0).Split(","c)
                    Dim n As Integer = CInt(config(0).Trim())
                    Dim m As Integer = CInt(config(1).Trim())

                    NumericProcesos.Value = n
                    NumericRecursos.Value = m
                    ConfigurarDataGridViews(n, m)

                    ' 2. Leer las matrices Allocation y Max desde el archivo
                    ' Estructura esperada del CSV:
                    ' Línea 0: N, M
                    ' Líneas 1 a N: Filas de Allocation separadas por comas
                    ' Líneas N+1 a 2*N: Filas de Max separadas por comas
                    ' Última línea: Vector Available separado por comas

                    Dim indiceLinea As Integer = 1

                    ' Cargar Allocation
                    For i As Integer = 0 To n - 1
                        Dim valores() As String = lineas(indiceLinea).Split(","c)
                        For j As Integer = 0 To m - 1
                            tblAllocation.Rows(i).Cells(j + 1).Value = CInt(valores(j).Trim())
                        Next
                        indiceLinea += 1
                    Next

                    ' Cargar Max
                    For i As Integer = 0 To n - 1
                        Dim valores() As String = lineas(indiceLinea).Split(","c)
                        For j As Integer = 0 To m - 1
                            tblMax.Rows(i).Cells(j + 1).Value = CInt(valores(j).Trim())
                        Next
                        indiceLinea += 1
                    Next

                    ' Cargar Available (última línea)
                    If indiceLinea < lineas.Length Then
                        Dim valoresAvail() As String = lineas(indiceLinea).Split(","c)
                        For j As Integer = 0 To m - 1
                            tblAvailable.Rows(0).Cells(j).Value = CInt(valoresAvail(j).Trim())
                        Next
                    End If

                    ' Calcular Need automáticamente tras cargar
                    btnNeed.PerformClick()
                    MessageBox.Show("Archivo CSV cargado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Catch ex As Exception
                    MessageBox.Show("Error al procesar el archivo CSV: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub
End Class
