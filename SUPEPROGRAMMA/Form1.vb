Imports System
Imports System.IO
Imports System.Text
Imports System.IO.Compression

Public Class Form1
    Dim img(29) As String
    Dim percorso_md3 As String = ""
    Dim quote As String = Chr(34)
    Dim cartella As String
    Dim gzdoom_path As String
    Dim nome_actor As String
    Dim salva As Boolean = False
    Dim percorso_pk3 As String = ""



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inizializza()
        'My.Computer.Audio.Play("D:\Download\suono.wav")
        'My.Computer.Audio.Play(My.Resources.suono)
    End Sub
    Private Sub PictureBox1_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles SurfaceSKin0.DragEnter

        If e.Data.GetDataPresent(DataFormats.FileDrop, False) = True Then
            e.Effect = DragDropEffects.All
        End If
    End Sub
    Private Sub PictureBox1_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles SurfaceSKin0.DragDrop
        Dim droppedFiles As String() = e.Data.GetData(DataFormats.FileDrop)
        SurfaceSKin0.Image = Image.FromFile(droppedFiles(0))
        img(0) = droppedFiles(0)


    End Sub


    Private Sub PictureBox2_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles sf0_normal.DragDrop
        Dim droppedFiles As String() = e.Data.GetData(DataFormats.FileDrop)
        sf0_normal.Image = Image.FromFile(droppedFiles(0))
        img(1) = droppedFiles(0)
    End Sub
    Private Sub PictureBox3_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles sf0_metallic.DragEnter

        If e.Data.GetDataPresent(DataFormats.FileDrop, False) = True Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub PictureBox3_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles sf0_metallic.DragDrop
        Dim droppedFiles As String() = e.Data.GetData(DataFormats.FileDrop)
        sf0_metallic.Image = Image.FromFile(droppedFiles(0))
        img(2) = droppedFiles(0)
    End Sub
    Private Sub PictureBox4_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles sf0_roughness.DragEnter

        If e.Data.GetDataPresent(DataFormats.FileDrop, False) = True Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub PictureBox4_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles sf0_roughness.DragDrop
        Dim droppedFiles As String() = e.Data.GetData(DataFormats.FileDrop)
        sf0_roughness.Image = Image.FromFile(droppedFiles(0))
        img(3) = droppedFiles(0)
    End Sub
    Private Sub PictureBox5_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles sf0_ao.DragEnter

        If e.Data.GetDataPresent(DataFormats.FileDrop, False) = True Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub PictureBox5_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles sf0_ao.DragDrop
        Dim droppedFiles As String() = e.Data.GetData(DataFormats.FileDrop)
        sf0_ao.Image = Image.FromFile(droppedFiles(0))
        img(4) = droppedFiles(0)
    End Sub
    Private Sub PictureBox6_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles SurfaceSkin1.DragEnter

        If e.Data.GetDataPresent(DataFormats.FileDrop, False) = True Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub PictureBox6_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles SurfaceSkin1.DragDrop
        Dim droppedFiles As String() = e.Data.GetData(DataFormats.FileDrop)
        SurfaceSkin1.Image = Image.FromFile(droppedFiles(0))
        img(5) = droppedFiles(0)
    End Sub

    Private Sub PictureBox7_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles sf1_ao.DragEnter

        If e.Data.GetDataPresent(DataFormats.FileDrop, False) = True Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub PictureBox7_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles sf1_ao.DragDrop
        Dim droppedFiles As String() = e.Data.GetData(DataFormats.FileDrop)
        sf1_ao.Image = Image.FromFile(droppedFiles(0))
        img(6) = droppedFiles(0)

    End Sub
    Private Sub PictureBox8_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles sf1_normal.DragEnter

        If e.Data.GetDataPresent(DataFormats.FileDrop, False) = True Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub PictureBox8_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles sf1_normal.DragDrop
        Dim droppedFiles As String() = e.Data.GetData(DataFormats.FileDrop)
        sf1_normal.Image = Image.FromFile(droppedFiles(0))
        img(7) = droppedFiles(0)
    End Sub
    Private Sub PictureBox9_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles sf1_roughness.DragEnter

        If e.Data.GetDataPresent(DataFormats.FileDrop, False) = True Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub PictureBox9_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles sf1_roughness.DragDrop
        Dim droppedFiles As String() = e.Data.GetData(DataFormats.FileDrop)
        sf1_roughness.Image = Image.FromFile(droppedFiles(0))
        img(8) = droppedFiles(0)
    End Sub
    Private Sub PictureBox10_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles sf1_metallic.DragEnter

        If e.Data.GetDataPresent(DataFormats.FileDrop, False) = True Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub PictureBox10_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles sf1_metallic.DragDrop
        Dim droppedFiles As String() = e.Data.GetData(DataFormats.FileDrop)
        sf1_metallic.Image = Image.FromFile(droppedFiles(0))
        img(9) = droppedFiles(0)
    End Sub
    Private Sub PictureBox11_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles SurfaceSkin2.DragEnter

        If e.Data.GetDataPresent(DataFormats.FileDrop, False) = True Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub PictureBox11_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles SurfaceSkin2.DragDrop
        Dim droppedFiles As String() = e.Data.GetData(DataFormats.FileDrop)
        SurfaceSkin2.Image = Image.FromFile(droppedFiles(0))
        img(10) = droppedFiles(0)
    End Sub
    Private Sub PictureBox12_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles sf2_ao.DragEnter

        If e.Data.GetDataPresent(DataFormats.FileDrop, False) = True Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub PictureBox12_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles sf2_ao.DragDrop
        Dim droppedFiles As String() = e.Data.GetData(DataFormats.FileDrop)
        sf2_ao.Image = Image.FromFile(droppedFiles(0))
        img(11) = droppedFiles(0)
    End Sub
    Private Sub PictureBox13_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles sf2_normal.DragEnter

        If e.Data.GetDataPresent(DataFormats.FileDrop, False) = True Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub PictureBox13_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles sf2_normal.DragDrop
        Dim droppedFiles As String() = e.Data.GetData(DataFormats.FileDrop)
        sf2_normal.Image = Image.FromFile(droppedFiles(0))
        img(12) = droppedFiles(0)
    End Sub
    Private Sub PictureBox14_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles sf2_roughness.DragEnter

        If e.Data.GetDataPresent(DataFormats.FileDrop, False) = True Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub PictureBox14_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles sf2_roughness.DragDrop
        Dim droppedFiles As String() = e.Data.GetData(DataFormats.FileDrop)
        sf2_roughness.Image = Image.FromFile(droppedFiles(0))
        img(13) = droppedFiles(0)
    End Sub
    Private Sub PictureBox15_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles sf2_metallic.DragEnter

        If e.Data.GetDataPresent(DataFormats.FileDrop, False) = True Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub PictureBox15_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles sf2_metallic.DragDrop
        Dim droppedFiles As String() = e.Data.GetData(DataFormats.FileDrop)
        sf2_metallic.Image = Image.FromFile(droppedFiles(0))
        img(14) = droppedFiles(0)
    End Sub
    Private Sub PictureBox16_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles SurfaceSkin3.DragEnter

        If e.Data.GetDataPresent(DataFormats.FileDrop, False) = True Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub PictureBox16_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles SurfaceSkin3.DragDrop
        Dim droppedFiles As String() = e.Data.GetData(DataFormats.FileDrop)
        SurfaceSkin3.Image = Image.FromFile(droppedFiles(0))
        img(15) = droppedFiles(0)
    End Sub
    Private Sub PictureBox17_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles sf3_ao.DragEnter

        If e.Data.GetDataPresent(DataFormats.FileDrop, False) = True Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub PictureBox17_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles sf3_ao.DragDrop
        Dim droppedFiles As String() = e.Data.GetData(DataFormats.FileDrop)
        sf3_ao.Image = Image.FromFile(droppedFiles(0))
        img(16) = droppedFiles(0)
    End Sub
    Private Sub PictureBox18_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles sf3_normal.DragEnter

        If e.Data.GetDataPresent(DataFormats.FileDrop, False) = True Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub PictureBox18_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles sf3_normal.DragDrop
        Dim droppedFiles As String() = e.Data.GetData(DataFormats.FileDrop)
        sf3_normal.Image = Image.FromFile(droppedFiles(0))
        img(17) = droppedFiles(0)
    End Sub
    Private Sub PictureBox19_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles sf3_roughness.DragEnter

        If e.Data.GetDataPresent(DataFormats.FileDrop, False) = True Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub PictureBox19_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles sf3_roughness.DragDrop
        Dim droppedFiles As String() = e.Data.GetData(DataFormats.FileDrop)
        sf3_roughness.Image = Image.FromFile(droppedFiles(0))
        img(18) = droppedFiles(0)
    End Sub
    Private Sub PictureBox20_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles sf3_metallic.DragEnter

        If e.Data.GetDataPresent(DataFormats.FileDrop, False) = True Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub PictureBox20_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles sf3_metallic.DragDrop
        Dim droppedFiles As String() = e.Data.GetData(DataFormats.FileDrop)
        sf3_metallic.Image = Image.FromFile(droppedFiles(0))
        img(19) = droppedFiles(0)
    End Sub
    Private Sub PictureBox21_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles SurfaceSkin4.DragEnter

        If e.Data.GetDataPresent(DataFormats.FileDrop, False) = True Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub PictureBox21_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles SurfaceSkin4.DragDrop
        Dim droppedFiles As String() = e.Data.GetData(DataFormats.FileDrop)
        SurfaceSkin4.Image = Image.FromFile(droppedFiles(0))
        img(20) = droppedFiles(0)
    End Sub
    Private Sub PictureBox22_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles sf4_ao.DragEnter

        If e.Data.GetDataPresent(DataFormats.FileDrop, False) = True Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub PictureBox22_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles sf4_ao.DragDrop
        Dim droppedFiles As String() = e.Data.GetData(DataFormats.FileDrop)
        sf4_ao.Image = Image.FromFile(droppedFiles(0))
        img(21) = droppedFiles(0)
    End Sub
    Private Sub PictureBox23_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles sf4_normal.DragEnter

        If e.Data.GetDataPresent(DataFormats.FileDrop, False) = True Then
            e.Effect = DragDropEffects.All
        End If
    End Sub
    Private Sub PictureBox23_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles sf4_normal.DragDrop
        Dim droppedFiles As String() = e.Data.GetData(DataFormats.FileDrop)
        sf4_normal.Image = Image.FromFile(droppedFiles(0))
        img(22) = droppedFiles(0)

    End Sub
    Private Sub PictureBox24_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles sf4_roughness.DragEnter

        If e.Data.GetDataPresent(DataFormats.FileDrop, False) = True Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub PictureBox24_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles sf4_roughness.DragDrop
        Dim droppedFiles As String() = e.Data.GetData(DataFormats.FileDrop)
        sf4_roughness.Image = Image.FromFile(droppedFiles(0))
        img(23) = droppedFiles(0)
    End Sub
    Private Sub PictureBox25_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles sf4_metallic.DragEnter

        If e.Data.GetDataPresent(DataFormats.FileDrop, False) = True Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub PictureBox25_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles sf4_metallic.DragDrop
        Dim droppedFiles As String() = e.Data.GetData(DataFormats.FileDrop)
        sf4_metallic.Image = Image.FromFile(droppedFiles(0))
        img(24) = droppedFiles(0)
    End Sub
    Private Sub PictureBox26_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles SurfaceSkin5.DragEnter

        If e.Data.GetDataPresent(DataFormats.FileDrop, False) = True Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub PictureBox26_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles SurfaceSkin5.DragDrop
        Dim droppedFiles As String() = e.Data.GetData(DataFormats.FileDrop)
        SurfaceSkin5.Image = Image.FromFile(droppedFiles(0))
        img(25) = droppedFiles(0)


    End Sub
    Private Sub PictureBox27_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles sf5_ao.DragEnter

        If e.Data.GetDataPresent(DataFormats.FileDrop, False) = True Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub PictureBox27_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles sf5_ao.DragDrop
        Dim droppedFiles As String() = e.Data.GetData(DataFormats.FileDrop)
        sf5_ao.Image = Image.FromFile(droppedFiles(0))
        img(26) = droppedFiles(0)
    End Sub
    Private Sub PictureBox28_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles sf5_normal.DragEnter

        If e.Data.GetDataPresent(DataFormats.FileDrop, False) = True Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub PictureBox28_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles sf5_normal.DragDrop
        Dim droppedFiles As String() = e.Data.GetData(DataFormats.FileDrop)
        sf5_normal.Image = Image.FromFile(droppedFiles(0))
        img(27) = droppedFiles(0)
    End Sub
    Private Sub PictureBox29_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles sf5_roughness.DragEnter

        If e.Data.GetDataPresent(DataFormats.FileDrop, False) = True Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub PictureBox29_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles sf5_roughness.DragDrop
        Dim droppedFiles As String() = e.Data.GetData(DataFormats.FileDrop)
        sf5_roughness.Image = Image.FromFile(droppedFiles(0))
        img(28) = droppedFiles(0)
    End Sub
    Private Sub PictureBox30_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles sf5_metallic.DragEnter

        If e.Data.GetDataPresent(DataFormats.FileDrop, False) = True Then
            e.Effect = DragDropEffects.All
        End If
    End Sub
    Private Sub PictureBox30_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles sf5_metallic.DragDrop
        Dim droppedFiles As String() = e.Data.GetData(DataFormats.FileDrop)
        sf5_metallic.Image = Image.FromFile(droppedFiles(0))
        img(29) = droppedFiles(0)
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog2.FileName = ""
        OpenFileDialog1.ShowDialog()
        percorso_md3 = OpenFileDialog1.FileName
        Label20.Text = Path.GetFileName(percorso_md3)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles SurfaceSKin0.Click
        carica_immagine(OpenFileDialog2, SurfaceSKin0, img(0))
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles SurfaceSkin1.Click
        carica_immagine(OpenFileDialog2, SurfaceSkin1, img(5))
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles SurfaceSkin2.Click
        carica_immagine(OpenFileDialog2, SurfaceSkin2, img(10))
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles SurfaceSkin3.Click
        carica_immagine(OpenFileDialog2, SurfaceSkin3, img(15))
    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles SurfaceSkin4.Click
        carica_immagine(OpenFileDialog2, SurfaceSkin4, img(20))
    End Sub

    Private Sub PictureBox26_Click(sender As Object, e As EventArgs) Handles SurfaceSkin5.Click
        carica_immagine(OpenFileDialog2, SurfaceSkin5, img(25))
    End Sub


    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles idle_check.CheckedChanged
        If idle_check.Checked = True Then
            idle_groupbox.Enabled = True
        Else
            idle_groupbox.Enabled = False
        End If


    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles fire_check.CheckedChanged
        If fire_check.Checked = True Then
            fire_groupbox.Enabled = True
        Else
            fire_groupbox.Enabled = False
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles select_check.CheckedChanged
        If select_check.Checked = True Then
            select_groupbox.Enabled = True
        Else
            select_groupbox.Enabled = False
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles deselect_check.CheckedChanged
        If deselect_check.Checked = True Then
            deselect_groupbox.Enabled = True
        Else
            deselect_groupbox.Enabled = False
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles custom1_check.CheckedChanged
        If custom1_check.Checked = True Then
            custom1_groupbox.Enabled = True
        Else
            custom1_groupbox.Enabled = False
        End If
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles custom2_check.CheckedChanged
        If custom2_check.Checked = True Then
            custom2_groupbox.Enabled = True
        Else
            custom2_groupbox.Enabled = False
        End If

    End Sub

    Function genera_frames(ByRef nome As String, ByRef inizio As Integer, ByRef fine As Integer) As String
        Dim delta = fine - inizio
        Dim numero = inizio - 1
        Dim s As String
        Dim stopp As Integer
        Dim cara As Char
        Dim risultato As String = ""
        stopp = 0

        Dim sprite As String
        If delta > 25 Then
            sprite = nome

            For i As Integer = 1 To Math.Ceiling(delta / 26)



                For c As Integer = 1 To 26
                    numero = numero + 1
                    stopp = stopp + 1

                    s = "FrameIndex " + sprite + " " + Chr(c + 64) + " 0 " + CStr(numero)
                    risultato = risultato + s
                    risultato = risultato + vbCrLf
                    If stopp - 1 = delta Then
                        Exit For
                    End If
                Next
                cara = sprite.Chars(3)
                sprite = sprite.Remove(3)
                sprite = sprite + Chr(Asc(cara) + 1)
            Next
        Else
            sprite = nome
            For i As Integer = 1 To delta + 1
                numero = numero + 1
                s = "FrameIndex " + sprite + " " + Chr(i + 64) + " 0 " + CStr(numero)
                risultato = risultato + s
                risultato = risultato + vbCrLf
            Next
        End If


        Return risultato
    End Function

    Function genera_frames_decorate(ByRef nome As String, ByRef inizio As Integer, ByRef fine As Integer, ByVal weaponready As Boolean, ByVal lower As Boolean) As String
        Dim delta = fine - inizio
        Dim numero = inizio - 1
        Dim s As String
        Dim stopp As Integer
        Dim cara As Char
        Dim risultato As String = ""
        stopp = 0

        Dim sprite As String
        Dim sprite_corrente As String = ""
        If delta > 25 Then
            sprite = nome

            For i As Integer = 1 To Math.Ceiling(delta / 26)
                risultato = risultato + sprite + " "
                For c As Integer = 1 To 26

                    stopp = stopp + 1
                    risultato = risultato + Chr(c + 64)

                    If stopp - 1 = delta Then
                        Exit For
                    End If
                Next
                risultato = risultato + " 1"
                If weaponready = True Then
                    risultato = risultato + " A_WeaponReady"
                End If
                If lower = True Then
                    risultato = risultato + " A_Lower"
                End If
                risultato = risultato + vbCrLf
                cara = sprite.Chars(3)
                sprite = sprite.Remove(3)
                sprite = sprite + Chr(Asc(cara) + 1)
            Next
        Else
            sprite = nome
            risultato = risultato + sprite + " "
            For i As Integer = 1 To delta + 1
                risultato = risultato + Chr(i + 64)
            Next
            risultato = risultato + " 1"
            If weaponready = True Then
                risultato = risultato + " A_WeaponReady"
            End If
            If lower = True Then
                risultato = risultato + " A_Lower"
            End If
            risultato = risultato + vbCrLf
        End If


        Return risultato
    End Function


    Function inizializza()

        With SurfaceSKin0
            .AllowDrop = True
            .BorderStyle = BorderStyle.FixedSingle
            .SizeMode = PictureBoxSizeMode.StretchImage
        End With
        With sf0_normal
            .AllowDrop = True
            .BorderStyle = BorderStyle.FixedSingle
            .SizeMode = PictureBoxSizeMode.StretchImage
        End With
        With sf0_metallic
            .AllowDrop = True
            .BorderStyle = BorderStyle.FixedSingle
            .SizeMode = PictureBoxSizeMode.StretchImage
        End With
        With sf0_roughness
            .AllowDrop = True
            .BorderStyle = BorderStyle.FixedSingle
            .SizeMode = PictureBoxSizeMode.StretchImage
        End With
        With sf0_ao
            .AllowDrop = True
            .BorderStyle = BorderStyle.FixedSingle
            .SizeMode = PictureBoxSizeMode.StretchImage
        End With

        With SurfaceSkin1
            .AllowDrop = True
            .BorderStyle = BorderStyle.FixedSingle
            .SizeMode = PictureBoxSizeMode.StretchImage
        End With
        With sf1_ao
            .AllowDrop = True
            .BorderStyle = BorderStyle.FixedSingle
            .SizeMode = PictureBoxSizeMode.StretchImage
        End With
        With sf1_normal
            .AllowDrop = True
            .BorderStyle = BorderStyle.FixedSingle
            .SizeMode = PictureBoxSizeMode.StretchImage
        End With
        With sf1_roughness
            .AllowDrop = True
            .BorderStyle = BorderStyle.FixedSingle
            .SizeMode = PictureBoxSizeMode.StretchImage
        End With
        With sf1_metallic
            .AllowDrop = True
            .BorderStyle = BorderStyle.FixedSingle
            .SizeMode = PictureBoxSizeMode.StretchImage
        End With
        With SurfaceSkin2
            .AllowDrop = True
            .BorderStyle = BorderStyle.FixedSingle
            .SizeMode = PictureBoxSizeMode.StretchImage
        End With
        With sf2_ao
            .AllowDrop = True
            .BorderStyle = BorderStyle.FixedSingle
            .SizeMode = PictureBoxSizeMode.StretchImage
        End With
        With sf2_normal
            .AllowDrop = True
            .BorderStyle = BorderStyle.FixedSingle
            .SizeMode = PictureBoxSizeMode.StretchImage
        End With
        With sf2_roughness
            .AllowDrop = True
            .BorderStyle = BorderStyle.FixedSingle
            .SizeMode = PictureBoxSizeMode.StretchImage
        End With
        With sf2_metallic
            .AllowDrop = True
            .BorderStyle = BorderStyle.FixedSingle
            .SizeMode = PictureBoxSizeMode.StretchImage
        End With
        With SurfaceSkin3
            .AllowDrop = True
            .BorderStyle = BorderStyle.FixedSingle
            .SizeMode = PictureBoxSizeMode.StretchImage
        End With
        With sf3_ao
            .AllowDrop = True
            .BorderStyle = BorderStyle.FixedSingle
            .SizeMode = PictureBoxSizeMode.StretchImage
        End With
        With sf3_normal
            .AllowDrop = True
            .BorderStyle = BorderStyle.FixedSingle
            .SizeMode = PictureBoxSizeMode.StretchImage
        End With
        With sf3_roughness
            .AllowDrop = True
            .BorderStyle = BorderStyle.FixedSingle
            .SizeMode = PictureBoxSizeMode.StretchImage
        End With
        With sf3_metallic
            .AllowDrop = True
            .BorderStyle = BorderStyle.FixedSingle
            .SizeMode = PictureBoxSizeMode.StretchImage
        End With
        With SurfaceSkin4
            .AllowDrop = True
            .BorderStyle = BorderStyle.FixedSingle
            .SizeMode = PictureBoxSizeMode.StretchImage
        End With
        With sf4_ao
            .AllowDrop = True
            .BorderStyle = BorderStyle.FixedSingle
            .SizeMode = PictureBoxSizeMode.StretchImage
        End With
        With sf4_normal
            .AllowDrop = True
            .BorderStyle = BorderStyle.FixedSingle
            .SizeMode = PictureBoxSizeMode.StretchImage
        End With
        With sf4_roughness
            .AllowDrop = True
            .BorderStyle = BorderStyle.FixedSingle
            .SizeMode = PictureBoxSizeMode.StretchImage
        End With
        With sf4_metallic
            .AllowDrop = True
            .BorderStyle = BorderStyle.FixedSingle
            .SizeMode = PictureBoxSizeMode.StretchImage
        End With
        With SurfaceSkin5
            .AllowDrop = True
            .BorderStyle = BorderStyle.FixedSingle
            .SizeMode = PictureBoxSizeMode.StretchImage
        End With
        With sf5_ao
            .AllowDrop = True
            .BorderStyle = BorderStyle.FixedSingle
            .SizeMode = PictureBoxSizeMode.StretchImage
        End With
        With sf5_normal
            .AllowDrop = True
            .BorderStyle = BorderStyle.FixedSingle
            .SizeMode = PictureBoxSizeMode.StretchImage
        End With
        With sf5_roughness
            .AllowDrop = True
            .BorderStyle = BorderStyle.FixedSingle
            .SizeMode = PictureBoxSizeMode.StretchImage
        End With
        With sf5_metallic
            .AllowDrop = True
            .BorderStyle = BorderStyle.FixedSingle
            .SizeMode = PictureBoxSizeMode.StretchImage
        End With
        SalvaToolStripMenuItem.Enabled = False
        SalvaConNomeToolStripMenuItem.Enabled = False
        DecorateToolStripMenuItem.Enabled = False
        ModeldefToolStripMenuItem.Enabled = False
        modeldef_panel.Enabled = False
        modeldef_panel.Visible = False
        decorate_panel.Enabled = False
        decorate_panel.Visible = False
        AnteprimeToolStripMenuItem.Enabled = False
        anteprima_panel.Enabled = False
        anteprima_panel.Visible = False

    End Function
    Function carica_immagine(ByRef dialog As OpenFileDialog, ByRef surfaceskin As PictureBox, ByRef percorso As String)
        dialog.FileName = ""
        dialog.ShowDialog()
        If dialog.FileName() <> "" Then
            percorso = dialog.FileName
            surfaceskin.Image = Image.FromFile(percorso)
        End If
    End Function


    Private Sub NuovoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuovoToolStripMenuItem.Click
        Dim Message, title, defaultValue As String
        Dim myValue As Object
        ' Set prompt.
        Message = "Inserire nome actor"
        ' Set title.
        title = "Nuovo actor"
        defaultValue = "1"   ' Set default value.

        ' Display message, title, and default value.
        myValue = InputBox(Message, title, defaultValue)
        ' If user has clicked Cancel, set myValue to defaultValue
        If myValue Is "" Then
            SalvaToolStripMenuItem.Enabled = False
            SalvaConNomeToolStripMenuItem.Enabled = False
            DecorateToolStripMenuItem.Enabled = False
            ModeldefToolStripMenuItem.Enabled = False
            AnteprimeToolStripMenuItem.Enabled = False
            modeldef_panel.Enabled = False
            modeldef_panel.Visible = False
            decorate_panel.Enabled = False
            decorate_panel.Visible = False
        Else
            modeldef_panel.Enabled = True
            modeldef_panel.Visible = True

            SalvaToolStripMenuItem.Enabled = True
            SalvaConNomeToolStripMenuItem.Enabled = True
            DecorateToolStripMenuItem.Enabled = True
            ModeldefToolStripMenuItem.Enabled = True
            AnteprimeToolStripMenuItem.Enabled = True
            nome_actor = myValue
            Label21.Text = nome_actor
            SalvaToolStripMenuItem.Enabled = True
            SalvaConNomeToolStripMenuItem.Enabled = True
        End If


    End Sub

    Private Sub SalvaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalvaToolStripMenuItem.Click
        RichTextBox1.Text = ""
        If salva = False Then
            SaveFileDialog1.ShowDialog()
            percorso_pk3 = SaveFileDialog1.FileName
        End If

        If percorso_pk3 <> "" Then



            cartella = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName())

            Directory.CreateDirectory(cartella)
            Directory.CreateDirectory(cartella + "\Models")
            Directory.CreateDirectory(cartella + "\Texture")
            If percorso_md3 <> "" Then
                File.Copy(percorso_md3, cartella + "\Models\" + Path.GetFileName(percorso_md3))
            End If

            genera_modeldef(True)
            Dim modStream As FileStream = File.Create(cartella + "\modeldef")
            Dim modInfo As Byte() = New UTF8Encoding(True).GetBytes(RichTextBox1.Text)
            modStream.Write(modInfo, 0, modInfo.Length)
            modStream.Close()

            genera_decorate()
            Dim decorate As FileStream = File.Create(cartella + "\decorate")
            Dim decInfo As Byte() = New UTF8Encoding(True).GetBytes(RichTextBox2.Text)
            decorate.Write(decInfo, 0, decInfo.Length)
            decorate.Close()

            Dim textures As FileStream = File.Create(cartella + "\TEXTURES")
            Dim texInfo As Byte() = New UTF8Encoding(True).GetBytes(genera_textureslump())
            textures.Write(texInfo, 0, texInfo.Length)
            textures.Close()

            If File.Exists(percorso_pk3) Then
                File.Delete(percorso_pk3)
            End If
            ZipFile.CreateFromDirectory(cartella, percorso_pk3, 0, False)
            Directory.Delete(cartella, True)
            salva = True
        End If

    End Sub

    Private Sub SalvaConNomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalvaConNomeToolStripMenuItem.Click
        RichTextBox1.Text = ""
        SaveFileDialog1.FileName = ""
        SaveFileDialog1.ShowDialog()


        If SaveFileDialog1.FileName <> "" Then
            percorso_pk3 = SaveFileDialog1.FileName
        End If

        If (percorso_pk3 <> "") And (SaveFileDialog1.FileName <> "") Then
            cartella = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName())

            Directory.CreateDirectory(cartella)
            Directory.CreateDirectory(cartella + "\Models")
            Directory.CreateDirectory(cartella + "\Texture")
            If percorso_md3 <> "" Then
                File.Copy(percorso_md3, cartella + "\Models\" + Path.GetFileName(percorso_md3))
            End If

            genera_modeldef(True)
            Dim modStream As FileStream = File.Create(cartella + "\modeldef")
            Dim modInfo As Byte() = New UTF8Encoding(True).GetBytes(RichTextBox1.Text)
            modStream.Write(modInfo, 0, modInfo.Length)
            modStream.Close()

            genera_decorate()
            Dim decorate As FileStream = File.Create(cartella + "\decorate")
            Dim decInfo As Byte() = New UTF8Encoding(True).GetBytes(RichTextBox2.Text)
            decorate.Write(decInfo, 0, decInfo.Length)
            decorate.Close()

            Dim textures As FileStream = File.Create(cartella + "\TEXTURES")
            Dim texInfo As Byte() = New UTF8Encoding(True).GetBytes(genera_textureslump())
            textures.Write(texInfo, 0, texInfo.Length)
            textures.Close()


            If File.Exists(percorso_pk3) Then
                File.Delete(percorso_pk3)
            End If
            ZipFile.CreateFromDirectory(cartella, percorso_pk3, 0, False)
            Directory.Delete(cartella, True)
            salva = True
        End If

    End Sub

    Private Sub ModeldefToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModeldefToolStripMenuItem.Click
        decorate_panel.Enabled = False
        decorate_panel.Visible = False
        anteprima_panel.Enabled = False
        anteprima_panel.Visible = False
        modeldef_panel.Enabled = True
        modeldef_panel.Visible = True
    End Sub

    Private Sub DecorateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DecorateToolStripMenuItem.Click
        modeldef_panel.Enabled = False
        modeldef_panel.Visible = False
        anteprima_panel.Enabled = False
        anteprima_panel.Visible = False
        decorate_panel.Enabled = True
        decorate_panel.Visible = True

    End Sub

    Private Sub bob_groupbox_check_CheckedChanged(sender As Object, e As EventArgs) Handles bob_groupbox_check.CheckedChanged
        If bob_groupbox_check.Checked = True Then
            bob_groupbox.Enabled = True
        Else
            bob_groupbox.Enabled = False
        End If
    End Sub


    Function genera_modeldef(ByVal copia As Boolean)
        RichTextBox1.Clear()
        RichTextBox1.AppendText("Model " + nome_actor + vbCrLf + "{" + vbCrLf + "Path ""models""" + vbCrLf + "Model 0 " + quote + OpenFileDialog1.SafeFileName + quote + vbCrLf)
        If img(0) <> "" Then
            RichTextBox1.AppendText("Path " + quote + "Texture" + quote + vbCrLf)
            RichTextBox1.AppendText("SurfaceSkin 0 0 " + quote + IO.Path.GetFileName(img(0)) + quote + vbCrLf)
            If copia = True Then
                File.Copy(img(0), cartella + "\Texture\" + Path.GetFileName(img(0)))
            End If


        End If
        If img(5) <> "" Then
            RichTextBox1.AppendText("SurfaceSkin 0 1 " + quote + IO.Path.GetFileName(img(5)) + quote + vbCrLf)
            If copia = True Then
                File.Copy(img(5), cartella + "\Texture\" + Path.GetFileName(img(5)))
            End If
        End If
        If img(10) <> "" Then
            RichTextBox1.AppendText("SurfaceSkin 0 2 " + quote + IO.Path.GetFileName(img(10)) + quote + vbCrLf)
            If copia = True Then
                File.Copy(img(10), cartella + "\Texture\" + Path.GetFileName(img(10)))
            End If
        End If
        If img(15) <> "" Then
            RichTextBox1.AppendText("SurfaceSkin 0 3 " + quote + IO.Path.GetFileName(img(15)) + quote + vbCrLf)
            If copia = True Then
                File.Copy(img(15), cartella + "\Texture\" + Path.GetFileName(img(15)))
            End If
        End If
        If img(20) <> "" Then
            RichTextBox1.AppendText("SurfaceSkin 0 4 " + quote + IO.Path.GetFileName(img(20)) + quote + vbCrLf)
            If copia = True Then
                File.Copy(img(20), cartella + "\Texture\" + Path.GetFileName(img(20)))
            End If
        End If
        If img(25) <> "" Then
            RichTextBox1.AppendText("SurfaceSkin 0 5 " + quote + IO.Path.GetFileName(img(25)) + quote + vbCrLf)
            If copia = True Then
                File.Copy(img(25), cartella + "\Texture\" + Path.GetFileName(img(25)))
            End If
        End If
        If AngleOffset.Checked = True Then
            RichTextBox1.AppendText("AngleOffset 90" + vbCrLf)
        End If
        If idle_check.Checked = True Then
            RichTextBox1.AppendText("///////////////////////IDLE/////////////////" + vbCrLf)
            RichTextBox1.AppendText(genera_frames(idle_text.Text, idle_inizio.Value, idle_fine.Value))
        End If
        If fire_check.Checked = True Then
            RichTextBox1.AppendText("///////////////////////FIRE/////////////////" + vbCrLf)
            RichTextBox1.AppendText(genera_frames(fire_text.Text, fire_inizio.Value, fire_fine.Value))
        End If
        If select_check.Checked = True Then
            RichTextBox1.AppendText("///////////////////////SELECT/////////////////" + vbCrLf)
            RichTextBox1.AppendText(genera_frames(select_text.Text, select_inizio.Value, select_fine.Value))
        End If
        If deselect_check.Checked = True Then
            RichTextBox1.AppendText("///////////////////////DESELECT/////////////////" + vbCrLf)
            RichTextBox1.AppendText(genera_frames(deselect_text.Text, deselect_inizio.Value, deselect_fine.Value))
        End If
        If custom1_check.Checked = True Then
            RichTextBox1.AppendText("///////////////////////CUSTOM1/////////////////" + vbCrLf)
            RichTextBox1.AppendText(genera_frames(custom1_text.Text, custom1_inizio.Value, custom1_fine.Value))
        End If
        If custom2_check.Checked = True Then
            RichTextBox1.AppendText("///////////////////////CUSTOM2/////////////////" + vbCrLf)
            RichTextBox1.AppendText(genera_frames(custom2_text.Text, custom2_inizio.Value, custom2_fine.Value))
        End If
        RichTextBox1.AppendText("}" + vbCrLf)
    End Function

    Function genera_decorate()
        RichTextBox2.Clear()
        RichTextBox2.AppendText("Actor " + nome_actor + " : Weapon" + vbCrLf + "{" + vbCrLf)
        RichTextBox2.AppendText("Scale " + Str(weapon_scale.Value) + vbCrLf)
        RichTextBox2.AppendText("Height " + Str(weapon_height.Value) + vbCrLf)
        RichTextBox2.AppendText("Radius " + Str(weapon_radius.Value) + vbCrLf)
        RichTextBox2.AppendText("Inventory.PickupMessage " + quote + pickup_message.Text + quote + vbCrLf)
        RichTextBox2.AppendText("Weapon.Kickback " + Str(weapon_kickback.Value) + vbCrLf)
        RichTextBox2.AppendText("Weapon.AmmoType " + quote + ammo_type.SelectedItem + quote + vbCrLf)
        RichTextBox2.AppendText("Weapon.AmmoUse " + Str(ammo_use.Value) + vbCrLf)
        RichTextBox2.AppendText("Weapon.AmmoGive " + Str(ammo_give.Value) + vbCrLf)
        RichTextBox2.AppendText("Weapon.SelectionOrder " + Str(selection_order.Value) + vbCrLf)
        RichTextBox2.AppendText("Weapon.SlotPriority " + Str(slot_priority.Value) + vbCrLf)
        RichTextBox2.AppendText("Weapon.SlotNumber " + slot_number.SelectedItem + vbCrLf)
        If bob_groupbox_check.Checked = True Then
            RichTextBox2.AppendText("Weapon.BobRangeX " + Str(bob_rangex.Value) + vbCrLf)
            RichTextBox2.AppendText("Weapon.BobRangeY " + Str(bob_rangey.Value) + vbCrLf)
            RichTextBox2.AppendText("Weapon.BobSpeed " + Str(bob_speed.Value) + vbCrLf)
            If bob_inverse.Checked = True Then
                If bob_style.SelectedItem = "Normal" Then
                    RichTextBox2.AppendText("Weapon.BobStyle " + quote + "Inverse" + quote + vbCrLf)
                Else
                    RichTextBox2.AppendText("Weapon.BobStyle " + quote + "Inverse" + bob_style.SelectedItem + quote + vbCrLf)
                End If
            Else
                RichTextBox2.AppendText("Weapon.BobStyle " + quote + bob_style.SelectedItem + quote + vbCrLf)
            End If
        End If

        'STATI

        RichTextBox2.AppendText("States " + vbCrLf + "{" + vbCrLf)
        RichTextBox2.AppendText("Spawn: " + vbCrLf + "PIST A -1" + vbCrLf + "Loop" + vbCrLf)

        'READY
        RichTextBox2.AppendText("Ready:" + vbCrLf)
        If idle_check.Checked = True Then
            RichTextBox2.AppendText(genera_frames_decorate(idle_text.Text, idle_inizio.Value, idle_fine.Value, True, False))
        Else
            RichTextBox2.AppendText("PISG A 1" + " A_WeaponReady" + vbCrLf)
        End If
        RichTextBox2.AppendText("Loop" + vbCrLf)

        'DESELECT
        RichTextBox2.AppendText("Deselect:" + vbCrLf)
        If idle_check.Checked = True Then
            RichTextBox2.AppendText(genera_frames_decorate(deselect_text.Text, deselect_inizio.Value, deselect_fine.Value, False, True))
        Else
            RichTextBox2.AppendText("PISG A 1" + " A_Lower" + vbCrLf)
        End If
        RichTextBox2.AppendText("Loop" + vbCrLf)

        'SELECT
        RichTextBox2.AppendText("Select:" + vbCrLf)
        RichTextBox2.AppendText("TNT1 A 0 A_Raise" + vbCrLf + "TNT1 A 0 A_WeaponOffset(0,32)" + vbCrLf)
        If idle_check.Checked = True Then
            RichTextBox2.AppendText(genera_frames_decorate(select_text.Text, select_inizio.Value, select_fine.Value, True, False))
        Else
            RichTextBox2.AppendText("PISG A 1" + " A_WeaponReady" + vbCrLf)
        End If
        RichTextBox2.AppendText("Loop" + vbCrLf)

        'FIRE
        RichTextBox2.AppendText("Fire:" + vbCrLf)
        If idle_check.Checked = True Then
            RichTextBox2.AppendText(genera_frames_decorate(fire_text.Text, fire_inizio.Value, fire_fine.Value, False, False))
        Else
            RichTextBox2.AppendText("PISG A 1" + " A_WeaponReady" + vbCrLf)
        End If
        RichTextBox2.AppendText("Goto Ready" + vbCrLf)


        RichTextBox2.AppendText("}" + vbCrLf + "}")
    End Function

    Function genera_textureslump() As String
        Dim res As String = ""
        If idle_check.Checked = True Then
            res = res + "sprite " + idle_text.Text + "A0, 1, 1 {Patch TNT1A0, 0, 0}" + vbCrLf
        End If
        If fire_check.Checked = True Then
            res = res + "sprite " + fire_text.Text + "A0, 1, 1 {Patch TNT1A0, 0, 0}" + vbCrLf
        End If
        If select_check.Checked = True Then
            res = res + "sprite " + select_text.Text + "A0, 1, 1 {Patch TNT1A0, 0, 0}" + vbCrLf
        End If
        If deselect_check.Checked = True Then
            res = res + "sprite " + deselect_text.Text + "A0, 1, 1 {Patch TNT1A0, 0, 0}" + vbCrLf
        End If

        genera_textureslump = res
    End Function

    Function genera_gldef() As String
        Dim res As String = ""

        If sf0_normal.Image Is Nothing Then

        End If
    End Function

    Private Sub AnteprimeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnteprimeToolStripMenuItem.Click
        anteprima_panel.Enabled = True
        anteprima_panel.Visible = True
        decorate_panel.Enabled = False
        decorate_panel.Visible = False
        modeldef_panel.Enabled = False
        modeldef_panel.Visible = False
        genera_decorate()
        genera_modeldef(False)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class
