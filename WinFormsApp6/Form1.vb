Imports WinFormsApp6.Models
Imports Microsoft.EntityFrameworkCore
Imports Microsoft

Public Class Form1
    Private Sub ListarCiudadesYPaisesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarCiudadesYPaisesToolStripMenuItem.Click
        Panel1.Visible = True
        Panel2.Visible = False
        Using contexto = New BaseContext()
            Dim paises = contexto.Pais.ToList()
            ComboBox1.DataSource = paises
            Dim datos = (From ciu In contexto.Ciudads.
                             Include("IdPaisNavigation")
                         Select New CiudadDTO With {
                                .IdCiudad = ciu.Id,
                                .NombreCiudad = ciu.Nombre,
                                .NombrePais = ciu.IdPaisNavigation.Nombre
                                 }
                             ).ToList()
            'Dim datos = contexto.Ciudads.
            ' Include("IdPaisNavigation").ToList()
            DataGridView1.DataSource = datos
        End Using
    End Sub

    Private Sub ListarConsultaSQLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarConsultaSQLToolStripMenuItem.Click
        Panel1.Visible = False
        Panel2.Visible = True
        Using contexto = New BaseContext()
            Dim paises = contexto.Pais.ToList()
            ComboBox2.DataSource = paises
            Dim sql As FormattableString =
                $"select pais.Id idpais,
	                pais.Nombre nombrepais,
	                ciudad.Id idciudad,
	                ciudad.Nombre nombreciudad
	                from pais
	                inner join ciudad on pais.Id=ciudad.IdPais"
            Dim resultado = contexto.CiudadDTOs.FromSql(sql).ToList()

            DataGridView2.DataSource = resultado
        End Using

    End Sub

    Private Sub ComboBox1_ValueMemberChanged(sender As Object, e As EventArgs) Handles ComboBox1.ValueMemberChanged

    End Sub

    Private Sub ComboBox1_TextUpdate(sender As Object, e As EventArgs) Handles ComboBox1.TextUpdate

    End Sub

    Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedValueChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim seleccion As Pai = ComboBox1.SelectedItem
        Using contexto = New BaseContext()

            Dim datos = (From ciu In contexto.Ciudads.
                             Include("IdPaisNavigation")
                         Where ciu.IdPaisNavigation.Id = seleccion.Id
                         Select New CiudadDTO With {
                                .IdCiudad = ciu.Id,
                                .NombreCiudad = ciu.Nombre,
                                .NombrePais = ciu.IdPaisNavigation.Nombre
                                 }
                             ).ToList()
            'Dim datos = contexto.Ciudads.
            ' Include("IdPaisNavigation").ToList()
            DataGridView1.DataSource = datos
        End Using
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim seleccion As Pai = ComboBox2.SelectedItem
        Using contexto = New BaseContext()
            Dim paises = contexto.Pais.ToList()
            ComboBox1.DataSource = paises
            Dim sql As FormattableString =
                $"select pais.Id idpais,
	                pais.Nombre nombrepais,
	                ciudad.Id idciudad,
	                ciudad.Nombre nombreciudad
	                from pais               
	                inner join ciudad on pais.Id=ciudad.IdPais
                     where pais.id={seleccion.Id}"
            Dim resultado = contexto.CiudadDTOs.FromSql(sql).ToList()

            DataGridView2.DataSource = resultado
        End Using
    End Sub
End Class
