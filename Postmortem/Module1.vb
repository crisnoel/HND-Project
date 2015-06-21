Imports System.Security.Cryptography 'import library
Imports System.IO 'import library
Imports System.Text 'import library
Imports System.Environment 'import library
Imports System.Diagnostics 'import library
Imports System.Threading 'import library
Imports System.Data.OleDb 'import library
Imports System.Windows.Forms.DialogResult 'import library
Imports System.Drawing 'import library

Public Module Module1

    Public VerifyHash As String 'public string variable declaration
    Public VerifiedHash As String 'public string variable declaration
    Public Filelocation As String 'public string variable declaration
    Public EventLogStatement1 As String 'public string variable declaration
    Public EventLogStatement2 As String 'public string variable declaration
    Public EventLogStatement3 As String 'public string variable declaration
    Public EventLogStatement4 As String 'public string variable declaration
    Public EventLogStatement5 As String 'public string variable declaration
    Public AlgorithmSelection As Integer 'public integer variable declaration
    Public TheEvidenceFile As String 'public string variable declaration
    Public HashCalculation As String 'public string variable declaration
    Public TheEvidenceFileVerify As String 'public string variable declaration
    Public HashCalculationVerify As String 'public string variable declaration
    Public SHATheEvidenceFile As String 'public string variable declaration
    Public SHAHashCalculation As String 'public string variable declaration
    Public SHATheEvidenceFileVerify As String 'public string variable declaration
    Public SHAHashCalculationVerify As String 'public string variable declaration
    Public SHA256TheEvidenceFile As String 'public string variable declaration
    Public SHA256HashCalculation As String 'public string variable declaration
    Public SHA256TheEvidenceFileVerify As String 'public string variable declaration
    Public SHA256HashCalculationVerify As String 'public string variable declaration
    Public SHA384TheEvidenceFile As String 'public string variable declaration
    Public SHA384HashCalculation As String 'public string variable declaration
    Public SHA384TheEvidenceFileVerify As String 'public string variable declaration
    Public SHA384HashCalculationVerify As String 'public string variable declaration
    Public DBLocation As String 'public string variable declaration
    Public DatabaseProvider As String 'public string variable declaration
    Public DAdapter As New OleDb.OleDbDataAdapter 'public data adapter declaration
    Public DSet As New DataSet 'public integer variable declaration
    Public inc As Integer 'public integer variable declaration
    Public MaxRowsEvidence As Integer 'public integer variable declaration
    Public MaxRowsEvidenceSearch As Integer 'public integer variable declaration
    Public CaseSearch As Integer 'public integer variable declaration
    Public HashSearch As String 'public string variable declaration
    Public cnnOLEDB As New OleDbConnection 'public oledb declaration
    Public ExportCase As String 'public string variable declaration
    Public ExportChain As String 'public string variable declaration
    Public ExportSerial As String 'public string variable declaration
    Public ExportDate As Date 'public date variable declaration
    Public ExportVerified As String 'public string variable declaration
    Public ExportAlgorithm As String 'public string variable declaration
End Module
