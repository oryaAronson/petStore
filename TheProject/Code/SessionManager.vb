Public Class SessionManager
    Const _USER As String = "Usr"
    Const _USER_ROLE As String = "USER"
    Const _MANAGER_ROLE As String = "MANAGER"

    Private Shared _session As SessionState.HttpSessionState
    Private Shared _pets As List(Of Pet)
    Private Shared _users As List(Of UserVM)
    Private Shared ReadOnly Property Session() As SessionState.HttpSessionState
        Get

            If _session Is Nothing Then
                _session = HttpContext.Current.Session

            End If

            Return _session
        End Get

    End Property

    Public Shared Property Pets() As List(Of Pet)
        Get

            If _pets Is Nothing Then
                _pets = New List(Of Pet) From {
        New Pet("111111111", "dog", 1500, "http://www.galmir.co.il/product.asp?num=12973&rootCat="),
        New Pet("222222222", "dog", 1500, "https://cellcomshop.cellcom.co.il/pub/media/catalog/product/cache/b8e43b67ccbb6ff8f872deb3a434a8cc/s/a/samsungs10_-white-front_1_2.png"),
        New Pet("333333333", "dog", 1500, "https://cellcomshop.cellcom.co.il/pub/media/catalog/product/cache/b8e43b67ccbb6ff8f872deb3a434a8cc/s/a/samsungs10_-white-front_1_2.png"),
        New Pet("444444444", "dog", 1500, "https://cellcomshop.cellcom.co.il/pub/media/catalog/product/cache/b8e43b67ccbb6ff8f872deb3a434a8cc/s/a/samsungs10_-white-front_1_2.png"),
        New Pet("555555555", "dog", 1500, "https://cellcomshop.cellcom.co.il/pub/media/catalog/product/cache/b8e43b67ccbb6ff8f872deb3a434a8cc/s/a/samsungs10_-white-front_1_2.png"),
        New Pet("666666666", "dog", 1500, "https://cellcomshop.cellcom.co.il/pub/media/catalog/product/cache/b8e43b67ccbb6ff8f872deb3a434a8cc/s/a/samsungs10_-white-front_1_2.png"),
        New Pet("777777777", "dog", 1500, "https://cellcomshop.cellcom.co.il/pub/media/catalog/product/cache/b8e43b67ccbb6ff8f872deb3a434a8cc/s/a/samsungs10_-white-front_1_2.png"),
        New Pet("888888888", "dog", 1500, "https://cellcomshop.cellcom.co.il/pub/media/catalog/product/cache/b8e43b67ccbb6ff8f872deb3a434a8cc/s/a/samsungs10_-white-front_1_2.png"),
        New Pet("999999999", "dog", 1500, "https://cellcomshop.cellcom.co.il/pub/media/catalog/product/cache/b8e43b67ccbb6ff8f872deb3a434a8cc/s/a/samsungs10_-white-front_1_2.png"),
        New Pet("121212121", "dog", 1500, "https://cellcomshop.cellcom.co.il/pub/media/catalog/product/cache/b8e43b67ccbb6ff8f872deb3a434a8cc/s/a/samsungs10_-white-front_1_2.png"),
        New Pet("131313131", "dog", 1500, "https://cellcomshop.cellcom.co.il/pub/media/catalog/product/cache/b8e43b67ccbb6ff8f872deb3a434a8cc/s/a/samsungs10_-white-front_1_2.png"),
        New Pet("454545454", "dog", 1500, "https://cellcomshop.cellcom.co.il/pub/media/catalog/product/cache/b8e43b67ccbb6ff8f872deb3a434a8cc/s/a/samsungs10_-white-front_1_2.png")
        }

            End If


            Return _pets
        End Get
        Set(ByVal pets As List(Of Pet))
            _pets = pets
        End Set

    End Property

    Public Shared ReadOnly Property Users() As List(Of UserVM)
        Get
            Dim userRole = New List(Of String) From {_USER_ROLE}
            Dim managerRole = New List(Of String) From {_USER_ROLE, _MANAGER_ROLE}
            If _users Is Nothing Then
                _users = New List(Of UserVM) From {
          New UserVM(1, "Yonatan", "Yonatan@Epr.co.il", 38, userRole),
          New UserVM(2, "Harel", "Harel@Epr.co.il", 38, userRole),
          New UserVM(1, "Orya", "Orya@Epr.co.il", 38, managerRole)
                }


            End If


            Return _users
        End Get

    End Property

    Public Shared Property User() As UserVM
        Get
            Return Session(_USER)
        End Get
        Set(ByVal usr As UserVM)
            Session(_USER) = usr
        End Set
    End Property

    Public Shared ReadOnly Property IsConnect() As Boolean
        Get
            Return User IsNot Nothing
        End Get

    End Property
    Public Shared ReadOnly Property IsManager() As Boolean
        Get
            Return User.Roles.Contains("managerRole")
        End Get

    End Property

End Class