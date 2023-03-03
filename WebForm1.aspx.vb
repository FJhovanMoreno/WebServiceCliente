Public Class WebForm1
    Inherits System.Web.UI.Page
    'Llamado al webservice
    Dim operaciones = New WSoperaciones.WebService1SoapClient()

    'Sección del código de los eventos asociados al formulario, con las respectivas referencias 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    'Ejecucion de la función suma
    Protected Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click

        Me.txtResultado.Text = operaciones.Suma(Me.txtNum1.Text, Me.txtNum2.Text)

    End Sub
    'Ejecución de la función resta
    Protected Sub btnResta_Click(sender As Object, e As EventArgs) Handles btnResta.Click
        
        Me.txtResultado.Text = operaciones.Resta(Me.txtNum1.Text, Me.txtNum2.Text)
        
    End Sub
    'Ejecución de la función multiplicación
    Protected Sub btnMultiplicacion_Click(sender As Object, e As EventArgs) Handles btnMultiplicacion.Click
        
        Me.txtResultado.Text = operaciones.Multiplicacion(Me.txtNum1.Text, Me.txtNum2.Text)
        
    End Sub
    'Ejecución de la función División
    Protected Sub btnDivision_Click(sender As Object, e As EventArgs) Handles btnDivision.Click
        
        Me.txtResultado.Text = operaciones.Division(Me.txtNum1.Text, Me.txtNum2.Text)
        
    End Sub
    'Ejecución de la función de limpiado de los campos TextBox.
    Protected Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Me.txtResultado.Text = String.Empty
        Me.txtNum1.Text = String.Empty
        Me.txtNum2.Text = String.Empty
    End Sub
End Class
