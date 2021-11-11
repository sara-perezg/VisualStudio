Public Class Producto

    'Declaramos los atributos
    Private codigo As String
    Private descripcion As String
    Private precioU As Double
    'Atributo compartido con valor 1 para automatizar el atributo código
    Private Shared indicecodigo As Integer = 1

    'Definimos los métodos

    Public Sub New(des As String, pu As Double)

        codigo = "AR00" & indicecodigo
        indicecodigo += 1
        descripcion = des
        precioU = pu

    End Sub

    'Implementamos las propiedades de los objetos
    Public ReadOnly Property Codigo_Producto As String
        Get
            Return codigo
        End Get
    End Property

    Public ReadOnly Property Descripcion_Producto As String
        Get
            Return descripcion
        End Get
    End Property

    Public ReadOnly Property Precio_Producto As String
        Get
            Return precioU
        End Get

    End Property

End Class
