Imports System.Security.Cryptography
Imports System.Text
Module Hash_module
    Dim salt As String = "vE*(6BHL1aj&V@l<bAjf@hvKID8$iPHP%URCzccnlyNnsBLr[b8i2UqNl7!3VV4lSTBAujb{z]=NUHuG)R&Hj1ou5Dt_t1SP+3UY"
    Public Function hash512(password As String) As String
        Dim convertedToBytes As Byte() = Encoding.UTF8.GetBytes(password & salt)
        Dim hashType As HashAlgorithm = New SHA512Managed()
        Dim hashBytes As Byte() = hashType.ComputeHash(convertedToBytes)
        Dim hashedResult As String = Convert.ToBase64String(hashBytes)
        Return hashedResult
    End Function
End Module
