'Imports System.Drawing.Printing
Public Class Form2


    'SALES'
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles RhlTxt.TextChanged
        RhlLbl.Text = Val(RhlTxt.Text) * 737

        If Val(RhlTxt.Text = "") Then
            RhlLbl.Text = "00.00"
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles RhpTxt.TextChanged
        RhpLbl.Text = Val(RhpTxt.Text) * 725

        If Val(RhpTxt.Text = "") Then
            RhpLbl.Text = "00.00"
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles RhsTxt.TextChanged
        RhsLbl.Text = Val(RhsTxt.Text) * 1033

        If Val(RhsTxt.Text = "") Then
            RhsLbl.Text = "00.00"
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles PlTxt.TextChanged
        PlLbl.Text = Val(PlTxt.Text) * 707

        If Val(PlTxt.Text = "") Then
            PlLbl.Text = "00.00"
        End If
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles Pp320Txt.TextChanged
        Pp320Lbl.Text = Val(Pp320Txt.Text) * 972

        If Val(Pp320Txt.Text = "") Then
            Pp320Lbl.Text = "00.00"
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles SmlbTxt.TextChanged
        SmlbLbl.Text = Val(SmlbTxt.Text) * 1125

        If Val(SmlbTxt.Text = "") Then
            SmlbLbl.Text = "00.00"
        End If
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles FbTxt.TextChanged
        FbLbl.Text = Val(FbTxt.Text) * 952

        If Val(FbTxt.Text = "") Then
            FbLbl.Text = "00.00"
        End If
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles MhtTxt.TextChanged
        MhtLbl.Text = Val(MhtTxt.Text) * 307

        If Val(MhtTxt.Text = "") Then
            MhtLbl.Text = "00.00"
        End If
    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles MhtBottTxt.TextChanged
        MhtBottLbl.Text = Val(MhtBottTxt.Text) * 11

        If Val(MhtBottTxt.Text = "") Then
            MhtBottLbl.Text = "00.00"
        End If
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles CbTxt.TextChanged
        CbLbl.Text = Val(CbTxt.Text) * 620

        If Val(CbTxt.Text = "") Then
            CbLbl.Text = "00.00"
        End If
    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles CnbTxt.TextChanged
        CnbLbl.Text = Val(CnbTxt.Text) * 1567

        If Val(CnbTxt.Text = "") Then
            CnbLbl.Text = "00.00"
        End If
    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles FbcTxt.TextChanged
        FbcLbl.Text = Val(FbcTxt.Text) * 1102

        If Val(FbcTxt.Text = "") Then
            FbcLbl.Text = "00.00"
        End If
    End Sub

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles PpcTxt.TextChanged
        PpcLbl.Text = Val(PpcTxt.Text) * 1175

        If Val(PpcTxt.Text = "") Then
            PpcLbl.Text = "00.00"
        End If
    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles CcTxt.TextChanged
        CcLbl.Text = Val(CcTxt.Text) * 650

        If Val(CcTxt.Text = "") Then
            CcLbl.Text = "00.00"
        End If
    End Sub

    Private Sub TextBox16_TextChanged(sender As Object, e As EventArgs) Handles GekTxt.TextChanged
        GekLbl.Text = Val(GekTxt.Text) * 737

        If Val(GekTxt.Text = "") Then
            GekLbl.Text = "00.00"
        End If
    End Sub

    Private Sub PlBottTxt_TextChanged(sender As Object, e As EventArgs) Handles PlBottTxt.TextChanged
        PlBottLbl.Text = Val(PlBottTxt.Text) * 670

        If Val(PlBottTxt.Text = "") Then
            PlBottLbl.Text = "00.00"
        End If
    End Sub

    Private Sub RhslTxt_TextChanged(sender As Object, e As EventArgs) Handles RhslTxt.TextChanged
        RhslLbl.Text = Val(RhslTxt.Text) * 785

        If Val(RhslTxt.Text = "") Then
            RhslLbl.Text = "00.00"
        End If
    End Sub

    Private Sub RhslBottTxt_TextChanged(sender As Object, e As EventArgs) Handles RhslBottTxt.TextChanged
        RhslBottLbl.Text = Val(RhslBottTxt.Text) * 112.33

        If Val(RhslBottTxt.Text = "") Then
            RhslBottLbl.Text = "00.00"
        End If
    End Sub

    Private Sub FbBottTxt_TextChanged(sender As Object, e As EventArgs) Handles FbBottTxt.TextChanged
        FbBottLbl.Text = Val(FbBottTxt.Text) * 36.16

        If Val(FbBottTxt.Text = "") Then
            FbBottLbl.Text = "00.00"
        End If
    End Sub

    Private Sub ChocLagTxt_TextChanged(sender As Object, e As EventArgs) Handles ChocLagTxt.TextChanged
        ChocLagLbl.Text = Val(ChocLagTxt.Text) * 1582

        If Val(ChocLagTxt.Text = "") Then
            ChocLagLbl.Text = "00.00"
        End If
    End Sub

    Private Sub PamcTxt_TextChanged_1(sender As Object, e As EventArgs) Handles PamcTxt.TextChanged
        PamcLbl.Text = Val(PamcTxt.Text) * 1582

        If Val(PamcTxt.Text = "") Then
            PamcLbl.Text = "00.00"
        End If
    End Sub

    Private Sub KrcTxt_TextChanged(sender As Object, e As EventArgs) Handles KrcTxt.TextChanged
        KrcLbl.Text = Val(KrcTxt.Text) * 1770

        If Val(KrcTxt.Text = "") Then
            KrcLbl.Text = "00.00"
        End If
    End Sub

    Private Sub HscTxt_TextChanged(sender As Object, e As EventArgs) Handles HscTxt.TextChanged
        HscLbl.Text = Val(HscTxt.Text) * 1142

        If Val(HscTxt.Text = "") Then
            HscLbl.Text = "00.00"
        End If
    End Sub
    Private Sub SmlbBottTxt_TextChanged(sender As Object, e As EventArgs) Handles SmlbBottTxt.TextChanged
        SmlbBottLbl.Text = Val(SmlbBottTxt.Text) * 43.38

        If Val(SmlbBottTxt.Text = "") Then
            SmlbBottLbl.Text = "00.00"
        End If
    End Sub
    Private Sub SmfbTxt_TextChanged(sender As Object, e As EventArgs) Handles SmfbTxt.TextChanged
        SmfbLbl.Text = Val(SmfbTxt.Text) * 851

        If Val(SmfbTxt.Text = "") Then
            SmfbLbl.Text = "00.00"
        End If
    End Sub
    Private Sub SmfcTxt_TextChanged(sender As Object, e As EventArgs) Handles SmfcTxt.TextChanged
        SmfcLbl.Text = Val(SmfcTxt.Text) * 1102

        If Val(SmfcTxt.Text = "") Then
            SmfcLbl.Text = "00.00"
        End If
    End Sub

    'CONTAINERS RETURNED'
    Private Sub PpCompTxt_TextChanged(sender As Object, e As EventArgs) Handles PpCompTxt.TextChanged
        PpCompLbl.Text = Val(PpCompTxt.Text) * 120
    End Sub

    Private Sub PpShellTxt_TextChanged(sender As Object, e As EventArgs) Handles PpShellTxt.TextChanged
        PpShellLbl.Text = Val(PpShellTxt.Text) * 84
    End Sub

    Private Sub PpBottleTxt_TextChanged(sender As Object, e As EventArgs) Handles PpBottleTxt.TextChanged
        PpBottleLbl.Text = Val(PpBottleTxt.Text) * 1.5
    End Sub

    Private Sub RhlCompTxt_TextChanged(sender As Object, e As EventArgs) Handles RhlCompTxt.TextChanged
        RhlCompLbl.Text = Val(RhlCompTxt.Text) * 111
    End Sub

    Private Sub RhlShellTxt_TextChanged(sender As Object, e As EventArgs) Handles RhlShellTxt.TextChanged
        RhlShellLbl.Text = Val(RhlShellTxt.Text) * 84
    End Sub

    Private Sub RhlBottleTxt_TextChanged(sender As Object, e As EventArgs) Handles RhlBottleTxt.TextChanged
        RhlBottleLbl.Text = Val(RhlBottleTxt.Text) * 4.5
    End Sub

    Private Sub RhpCompTxt_TextChanged(sender As Object, e As EventArgs) Handles RhpCompTxt.TextChanged
        RhpCompLbl.Text = Val(RhpCompTxt.Text) * 111
    End Sub

    Private Sub RhpShellTxt_TextChanged(sender As Object, e As EventArgs) Handles RhpShellTxt.TextChanged
        RhpShellLbl.Text = Val(RhpShellTxt.Text) * 84
    End Sub

    Private Sub RhpBottleTxt_TextChanged(sender As Object, e As EventArgs) Handles RhpBottleTxt.TextChanged
        RhpBottleLbl.Text = Val(RhpBottleTxt.Text) * 2.25
    End Sub

    Private Sub FbaCompTxt_TextChanged(sender As Object, e As EventArgs) Handles FbaCompTxt.TextChanged
        FbaCompLbl.Text = Val(FbaCompTxt.Text) * 120
    End Sub

    Private Sub FbaShellTxt_TextChanged(sender As Object, e As EventArgs) Handles FbaShellTxt.TextChanged
        FbaShellLbl.Text = Val(FbaShellTxt.Text) * 84
    End Sub

    Private Sub FbaBottleTxt_TextChanged(sender As Object, e As EventArgs) Handles FbaBottleTxt.TextChanged
        FbaBottleLbl.Text = Val(FbaBottleTxt.Text) * 1.5
    End Sub

    Private Sub MhtCompTxt_TextChanged(sender As Object, e As EventArgs) Handles MhtCompTxt.TextChanged
        MhtCompLbl.Text = Val(MhtCompTxt.Text) * 78
    End Sub

    Private Sub MhtShellTxt_TextChanged(sender As Object, e As EventArgs) Handles MhtShellTxt.TextChanged
        MhtShellLbl.Text = Val(MhtShellTxt.Text) * 42
    End Sub

    Private Sub MhtBottleTxt_TextChanged(sender As Object, e As EventArgs) Handles MhtBottleTxt.TextChanged
        MhtBottleLbl.Text = Val(MhtBottleTxt.Text) * 1.5
    End Sub

    Private Sub TotalSalesLbl_Click(sender As Object, e As EventArgs) Handles TotalSalesLbl.Click
        TotalSalesLbl.Text = Val(RhlLbl.Text) + Val(RhpLbl.Text) + Val(RhsLbl.Text) + Val(PlLbl.Text) + Val(Pp320Lbl.Text) + Val(SmlbLbl.Text) + Val(FbLbl.Text) + Val(MhtLbl.Text) + Val(MhtBottLbl.Text) + Val(CbLbl.Text) + Val(CnbLbl.Text) + Val(FbcLbl.Text) + Val(PpcLbl.Text) + Val(CcLbl.Text) + Val(GekLbl.Text) + Val(PlBottLbl.Text) + Val(RhslLbl.Text) + Val(RhslBottLbl.Text) + Val(FbBottLbl.Text) + Val(ChocLagLbl.Text) + Val(PamcLbl.Text) + Val(KrcLbl.Text) + Val(HscLbl.Text) + Val(SmlbBottLbl.Text) + Val(SmfbLbl.Text) + Val(SmfcLbl.Text)
    End Sub

    Private Sub TotalContRetLbl_Click(sender As Object, e As EventArgs) Handles TotalContRetLbl.Click
        TotalContRetLbl.Text = Val(PpCompLbl.Text) + Val(PpShellLbl.Text) + Val(PpBottleLbl.Text) + Val(RhlCompLbl.Text) + Val(RhlShellLbl.Text) + Val(RhlBottleLbl.Text) + Val(RhpCompLbl.Text) + Val(RhpShellLbl.Text) + Val(RhpBottleLbl.Text) + Val(FbaCompLbl.Text) + Val(FbaShellLbl.Text) + Val(FbaBottleLbl.Text) + Val(MhtCompLbl.Text) + Val(MhtShellLbl.Text) + Val(MhtBottleLbl.Text) + Val(ReturnSku1Txt.Text) + Val(ReturnSku2Txt.Text) + Val(ReturnSku3Txt.Text)

    End Sub

    Private Sub GrossSalesLbl_Click(sender As Object, e As EventArgs) Handles GrossSalesLbl.Click
        GrossSalesLbl.Text = Val(TotalSalesLbl.Text) - Val(TotalContRetLbl.Text)
    End Sub

    Private Sub AmountRemittedLbl_Click(sender As Object, e As EventArgs) Handles AmountRemittedLbl.Click
        AmountRemittedLbl.Text = Val(GrossSalesLbl.Text) - Val(DiscTxt.Text) - Val(TolFTxt.Text) - Val(PromoTxt.Text) - Val(CreditAmountTxt1.Text) - Val(CreditAmountTxt2.Text) - Val(CreditAmountTxt3.Text) + Val(CollAmountTxt1.Text) + Val(CollAmountTxt2.Text) + Val(CollAmountTxt3.Text)
    End Sub

    'CASH BREAKDOWN'
    Private Sub ThousandsTxt_TextChanged(sender As Object, e As EventArgs) Handles ThousandsTxt.TextChanged
        ThousandsLbl.Text = Val(ThousandsTxt.Text) * 1000
    End Sub

    Private Sub FiveHundTxt_TextChanged(sender As Object, e As EventArgs) Handles FiveHundTxt.TextChanged
        FiveHundLbl.Text = Val(FiveHundTxt.Text) * 500
    End Sub

    Private Sub TwoHundTxt_TextChanged(sender As Object, e As EventArgs) Handles TwoHundTxt.TextChanged
        TwoHundLbl.Text = Val(TwoHundTxt.Text) * 200
    End Sub

    Private Sub OneHundTxt_TextChanged(sender As Object, e As EventArgs) Handles OneHundTxt.TextChanged
        OneHundLbl.Text = Val(OneHundTxt.Text) * 100
    End Sub

    Private Sub FiftyTxt_TextChanged(sender As Object, e As EventArgs) Handles FiftyTxt.TextChanged
        FiftyLbl.Text = Val(FiftyTxt.Text) * 50
    End Sub

    Private Sub TwentTxt_TextChanged(sender As Object, e As EventArgs) Handles TwentTxt.TextChanged
        TwentLbl.Text = Val(TwentTxt.Text) * 20
    End Sub

    Private Sub TenTxt_TextChanged(sender As Object, e As EventArgs) Handles TenTxt.TextChanged
        TenLbl.Text = Val(TenTxt.Text) * 10
    End Sub

    Private Sub FiveTxt_TextChanged(sender As Object, e As EventArgs) Handles FiveTxt.TextChanged
        FiveLbl.Text = Val(FiveTxt.Text) * 5
    End Sub

    Private Sub TotalRemitAmountLbl_Click(sender As Object, e As EventArgs) Handles TotalRemitAmountLbl.Click
        TotalRemitAmountLbl.Text = Val(ThousandsLbl.Text) + Val(FiveHundLbl.Text) + Val(TwoHundLbl.Text) + Val(OneHundLbl.Text) + Val(FiftyLbl.Text) + Val(TwentLbl.Text) + Val(TenLbl.Text) + Val(FiveLbl.Text) + Val(CoinsTxt.Text) + Val(BankAmountTxt1.Text) + Val(BankAmountTxt2.Text) + Val(BankAmountTxt3.Text)
    End Sub

    Private Sub SOLbl_Click(sender As Object, e As EventArgs) Handles SOLbl.Click

        SOLbl.Text = Val(TotalRemitAmountLbl.Text) - Val(AmountRemittedLbl.Text)

        If Val(AmountRemittedLbl.Text) > Val(TotalRemitAmountLbl.Text) Then
            MessageBox.Show("DSP is Short! " + SOLbl.Text)
        Else
            If Val(AmountRemittedLbl.Text) < Val(TotalRemitAmountLbl.Text) Then
                MessageBox.Show("DSP is Over! " + SOLbl.Text)

            End If
        End If
    End Sub

    Private Sub ClearAllTxtBtn_Click(sender As Object, e As EventArgs) Handles ClearAllTxtBtn.Click
        'SALES'
        RhlTxt.Text = ""
        RhpTxt.Text = ""
        RhsTxt.Text = ""
        PlTxt.Text = ""
        Pp320Txt.Text = ""
        SmlbTxt.Text = ""
        FbTxt.Text = ""
        MhtTxt.Text = ""
        MhtBottTxt.Text = ""
        CbTxt.Text = ""
        CnbTxt.Text = ""
        FbcTxt.Text = ""
        PpcTxt.Text = ""
        CcTxt.Text = ""
        GekTxt.Text = ""
        PlBottTxt.Text = ""
        RhslTxt.Text = ""
        RhslBottTxt.Text = ""
        FbBottTxt.Text = ""
        ChocLagTxt.Text = ""
        PamcTxt.Text = ""
        KrcTxt.Text = ""
        HscTxt.Text = ""
        SmlbBottTxt.Text = ""
        SmfbTxt.Text = ""
        SmfcTxt.Text = ""

        'SALES LABEL'
        RhlLbl.Text = "00.00"
        RhpLbl.Text = "00.00"
        RhsLbl.Text = "00.00"
        PlLbl.Text = "00.00"
        Pp320Lbl.Text = "00.00"
        SmlbLbl.Text = "00.00"
        FbLbl.Text = "00.00"
        MhtLbl.Text = "00.00"
        MhtBottLbl.Text = "00.00"
        CbLbl.Text = "00.00"
        CnbLbl.Text = "00.00"
        FbcLbl.Text = "00.00"
        PpcLbl.Text = "00.00"
        CcLbl.Text = "00.00"
        GekLbl.Text = "00.00"
        PlBottLbl.Text = "00.00"
        RhslLbl.Text = "00.00"
        RhslBottLbl.Text = "00.00"
        FbBottLbl.Text = "00.00"
        ChocLagLbl.Text = "00.00"
        PamcLbl.Text = "00.00"
        KrcLbl.Text = "00.00"
        HscLbl.Text = "00.00"
        SmlbBottLbl.Text = "00.00"
        SmfbLbl.Text = "00.00"
        SmfcLbl.Text = "00.00"

        'CONTAINERS RETURNED'
        PpCompTxt.Text = ""
        PpShellTxt.Text = ""
        PpBottleTxt.Text = ""

        RhlCompTxt.Text = ""
        RhlShellTxt.Text = ""
        RhlBottleTxt.Text = ""

        RhpCompTxt.Text = ""
        RhpShellTxt.Text = ""
        RhpBottleTxt.Text = ""

        FbaCompTxt.Text = ""
        FbaShellTxt.Text = ""
        FbaBottleTxt.Text = ""

        MhtCompTxt.Text = ""
        MhtShellTxt.Text = ""
        MhtBottleTxt.Text = ""

        'CONTAINERS RETURNED LABELS'
        PpCompLbl.Text = "00.00"
        PpShellLbl.Text = "00.00"
        PpBottleLbl.Text = "00.00"

        RhlCompLbl.Text = "00.00"
        RhlShellLbl.Text = "00.00"
        RhlBottleLbl.Text = "00.00"

        RhpCompLbl.Text = "00.00"
        RhpShellLbl.Text = "00.00"
        RhpBottleLbl.Text = "00.00"

        FbaCompLbl.Text = "00.00"
        FbaShellLbl.Text = "00.00"
        FbaBottleLbl.Text = "00.00"

        MhtCompLbl.Text = "00.00"
        MhtShellLbl.Text = "00.00"
        MhtBottleLbl.Text = "00.00"

        'CASH REMITTANCE COMP.'
        DiscTxt.Text = ""
        TolFTxt.Text = ""
        PromoTxt.Text = ""

        CreditAmountTxt1.Text = ""
        CreditAmountTxt2.Text = ""
        CreditAmountTxt3.Text = ""

        CollAmountTxt1.Text = ""
        CollAmountTxt2.Text = ""
        CollAmountTxt3.Text = ""

        'CASH BREAKDOWN'
        ThousandsTxt.Text = ""
        FiveHundTxt.Text = ""
        TwoHundTxt.Text = ""
        OneHundTxt.Text = ""
        FiftyTxt.Text = ""
        TwentTxt.Text = ""
        TenTxt.Text = ""
        FiveTxt.Text = ""
        CoinsTxt.Text = ""

        BankAmountTxt1.Text = ""
        BankAmountTxt2.Text = ""
        BankAmountTxt3.Text = ""

        'CASH BREAKDOWN LABELS'
        ThousandsLbl.Text = "00.00"
        FiveHundLbl.Text = "00.00"
        TwoHundLbl.Text = "00.00"
        OneHundLbl.Text = "00.00"
        FiftyLbl.Text = "00.00"
        TwentLbl.Text = "00.00"
        TenLbl.Text = "00.00"
        FiveLbl.Text = "00.00"


        'TOTAL LABELS'
        TotalSalesLbl.Text = "CLICK TO SEE TOTAL SALES"
        TotalContRetLbl.Text = "CLICK TO SEE TOTAL CONTAINERS RETURNED"
        GrossSalesLbl.Text = "CLICK TO SEE TOTAL GROSS SALES"
        AmountRemittedLbl.Text = "Click to see Amount"
        TotalRemitAmountLbl.Text = "Click To See Amount"
        SOLbl.Text = "Click To See Amount"

        'RETURNED SKU'
        ReturnSku1Txt.Text = ""
        ReturnSku2Txt.Text = ""
        ReturnSku3Txt.Text = ""

    End Sub
End Class