Public Class WebForm1
    Inherits System.Web.UI.Page
    Dim operaciones = New WSoperaciones.WebService1SoapClient()


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click

        Me.txtResultado.Text = operaciones.Suma(Me.txtNum1.Text, Me.txtNum2.Text)

    End Sub

    Protected Sub btnResta_Click(sender As Object, e As EventArgs) Handles btnResta.Click
        Me.txtResultado.Text = operaciones.Resta(Me.txtNum1.Text, Me.txtNum2.Text)
    End Sub

    Protected Sub btnMultiplicacion_Click(sender As Object, e As EventArgs) Handles btnMultiplicacion.Click
        Me.txtResultado.Text = operaciones.Multiplicacion(Me.txtNum1.Text, Me.txtNum2.Text)
    End Sub

    Protected Sub btnDivision_Click(sender As Object, e As EventArgs) Handles btnDivision.Click
        Me.txtResultado.Text = operaciones.Division(Me.txtNum1.Text, Me.txtNum2.Text)
    End Sub

    Protected Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Me.txtResultado.Text = String.Empty
        Me.txtNum1.Text = String.Empty
        Me.txtNum2.Text = String.Empty
    End Sub
End Class