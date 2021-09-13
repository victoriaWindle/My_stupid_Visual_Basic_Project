Public Class Form1

    Dim images() As Image = {My.Resources.Design_2, My.Resources.frog, My.Resources.Pencil, My.Resources.Pumpkin, My.Resources.Apple, My.Resources.tree, My.Resources.Books, My.Resources.Panda, My.Resources.Cat, My.Resources.Fork, My.Resources.Duck}
    'Dim picBoxes() As PictureBox = {picBox1, picBox2, picBox3, picBox4, picBox5, picBox6, picBox7, picBox8, picBox9}
    Dim value, value2, value3, value4, value5, value6, value7, value8, value9 As Integer
    Dim points, hi As Integer


    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        randomizeImage()

    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        'Would have liked to use a for each statement here...

        picBox1.Image = My.Resources.Design_2
        picBox2.Image = My.Resources.Design_2
        picBox3.Image = My.Resources.Design_2
        picBox4.Image = My.Resources.Design_2
        picBox5.Image = My.Resources.Design_2
        picBox6.Image = My.Resources.Design_2
        picBox7.Image = My.Resources.Design_2
        picBox8.Image = My.Resources.Design_2
        picBox9.Image = My.Resources.Design_2

        drop1.Enabled = True
        drop2.Enabled = True
        drop3.Enabled = True
        drop4.Enabled = True
        drop5.Enabled = True
        drop6.Enabled = True
        drop7.Enabled = True
        drop8.Enabled = True
        drop9.Enabled = True

        btnOne.Enabled = False
        btn3.Enabled = False
    End Sub

    Private Function randomizeImage()
        '...Or a for each statement here
        'there are 10 images because I like even numbers, the pictures do not come out completely random
        'I don't know why.
        value = CInt(Int((10 * Rnd()) + 1))
        picBox1.Image = images(value)

        value2 = CInt(Int((10 * Rnd()) + 1))
        picBox2.Image = images(value2)

        value3 = CInt(Int((10 * Rnd()) + 1))
        picBox3.Image = images(value3)

        value4 = CInt(Int((10 * Rnd()) + 1))
        picBox4.Image = images(value4)

        value5 = CInt(Int((10 * Rnd()) + 1))
        picBox5.Image = images(value5)

        value6 = CInt(Int((10 * Rnd()) + 1))
        picBox6.Image = images(value6)

        value7 = CInt(Int((10 * Rnd()) + 1))
        picBox7.Image = images(value7)

        value8 = CInt(Int((10 * Rnd()) + 1))
        picBox8.Image = images(value8)

        value9 = CInt(Int((10 * Rnd()) + 1))
        picBox9.Image = images(value9)


        Return (value, value2, value3, value4, value5, value6, value7, value8, value9)

    End Function



    Private Sub btn_Check_Click(sender As Object, e As EventArgs) Handles btn_Check.Click

        If drop1.SelectedIndex + 1 = value Then
            drop1.Enabled = False
            points = points + 10
        End If

        If drop2.SelectedIndex + 1 = value2 Then
            drop2.Enabled = False
            points = points + 10
        End If

        If drop3.SelectedIndex + 1 = value3 Then
            drop3.Enabled = False
            points = points + 10
        End If

        If drop4.SelectedIndex + 1 = value4 Then
            drop4.Enabled = False
            points = points + 10
        End If

        If drop5.SelectedIndex + 1 = value5 Then
            drop5.Enabled = False
            points = points + 10
        End If

        If drop6.SelectedIndex + 1 = value6 Then
            drop6.Enabled = False
            points = points + 10
        End If

        If drop7.SelectedIndex + 1 = value7 Then
            drop7.Enabled = False
            points = points + 10
        End If

        If drop8.SelectedIndex + 1 = value8 Then
            drop8.Enabled = False
            points = points + 10
        End If

        If drop9.SelectedIndex + 1 = value9 Then
            drop9.Enabled = False
            points = points + 10
        End If

        MessageBox.Show("you have " & points & " points")



        RefreshForm()

        lblTwo.Text = points
        If points >= 30 Then
            MessageBox.Show("30 pts: Fun fact: Crows have been observed using tools and can talk.")
        End If
        If points >= 50 Then
            MessageBox.Show("50 pts: Jesus is awesome!")
        End If
        If points >= 100 Then
            prize100()
        End If
        If points = 150 Then
            prize150()
        End If

    End Sub

    Private Sub RefreshForm()
        Me.Controls.Clear()
        Me.InitializeComponent()
    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        Close()
    End Sub

    'just cause I couldn't figure out how to use either in my actual code so here is proof I can do them as prizes lol
    Private Sub prize100()
        For hi = 0 To 10
            MessageBox.Show("100 pts: " & hi)
        Next
    End Sub
    Private Sub prize150()

        hi = 3
        Do Until hi = 6
            points = points + 1
            MessageBox.Show("150 pts: " & points)
        Loop

    End Sub

End Class
