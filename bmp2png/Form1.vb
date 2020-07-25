Imports System.Drawing.Imaging
Imports System.IO.Path

Public Class Form1
    Public Function ConvertBMP(ByVal BMPFullPath As String, _
    ByVal imgFormat As ImageFormat) As Boolean

        Dim bAns As Boolean
        Dim sNewFile As String

        Try
            'bitmap class in system.drawing.imaging
            Dim objBmp As New Bitmap(BMPFullPath)

            'below 2 functions in system.io.path
            sNewFile = GetDirectoryName(BMPFullPath) & "\"
            sNewFile &= GetFileNameWithoutExtension(BMPFullPath)

            sNewFile &= "." & imgFormat.ToString
            objBmp.Save(sNewFile, imgFormat)

            bAns = True 'return true on success
        Catch
            bAns = False 'return false on error
        End Try
        Return bAns

    End Function

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        ConvertBMP("f:\desktop\ss.bmp", ImageFormat.Png)
    End Sub
End Class
