Imports System.Xml.Schema

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Function HailstoneLength(seed As Long) As Integer

        'variables
        Dim length As Integer

        length = 0

        Do While seed >= 1

            ' Special case for 1
            If seed = 1 Then
                length += 1
                Exit Do
            End If

            If seed Mod 2 = 0 Then
                ' Even case
                seed /= 2
            Else
                ' Odd case
                seed = 3 * seed + 1
            End If

            'increment length
            length += 1
        Loop
        Return length
    End Function

    Function LengthsOfRange(upperBound As Integer) As Integer()

        ' variables
        Dim Lengths(upperBound) As Integer

        'generating hailstone length for each number from 1 to upper bound
        For num As Integer = 1 To upperBound
            Lengths(num) = HailstoneLength(num)
        Next

        Return Lengths

    End Function

    Sub PrintLengths(Lengths As Integer())

        ' formatting column headers
        Dim columns As String = "{0, -16}{1, -16}"
        LengthBox.Items.Add(String.Format(columns, "Number", "Length"))

        ' printing each entry to list
        For index = 0 To (Lengths.Length - 1)

            LengthBox.Items.Add(String.Format(columns, index, (Lengths(index))))

        Next

    End Sub

    Function LengthDist(Lengths As Integer()) As Integer()

        ' variables
        Dim lengthDists(Lengths.Max) As Integer

        'counting length count for each number in Lengths array
        For Each length As Integer In Lengths

            lengthDists(length) += 1

        Next

        Return lengthDists

    End Function

    Sub PrintDist(lengthDist As Integer())

        ' formatting column headers
        Dim columns As String = "{0, -16}{1, -16}{2, -16}"
        DistBox.Items.Add(String.Format(columns, "Length", "Amount", "% of Total"))

        ' variables
        Dim sum As Integer = SumDist(lengthDist) ' sum is the sum of all the values in the distribution
        Dim lengthCount As Integer
        Dim percentOfTotal As Double
        Dim percentCheck As Double

        ' Adding all the distributions to the list and getting the percentage of total
        For index = 0 To (lengthDist.Length - 1)

            lengthCount = lengthDist(index)

            If lengthDist(index) = 0 Then

                ' case if there is no value
                percentOfTotal = 0

            Else

                ' case if there is a value
                percentOfTotal = (lengthCount / sum) * 100
                percentCheck += percentOfTotal

            End If

            ' adding entries to list
            DistBox.Items.Add(String.Format(columns, index, lengthCount, Math.Round(percentOfTotal, 6)))

        Next

        ' adding footer to list
        DistBox.Items.Add(String.Format(columns, "Total", "", Math.Round(percentCheck, 6)))

    End Sub

    Sub PrintDistGraph(lengthDist As Integer())

        ' formatting headers
        Dim columns As String = "{0, -8}{1, -196}"
        DistGraph.Items.Add(String.Format(columns, "Length", "Occurances"))

        ' variables
        Dim bar As String = ""

        For index = 1 To (lengthDist.Length - 1)

            ' generating bar
            bar = StrDup(lengthDist(index), "|")

            ' adding bar to graph
            DistGraph.Items.Add(String.Format(columns, index, bar))

        Next

    End Sub

    Function SumDist(lengthDist As Integer()) As Double

        ' variables
        Dim sum As Integer = 0

        ' summing all numbers in lengthDist
        For Each number As Integer In lengthDist

            sum += number

        Next

        Return sum

    End Function

    Function CalcMean(lengthDist As Integer()) As Double

        'variables
        Dim mean As Double

        ' calculating mean
        mean = SumDist(lengthDist) / lengthDist.Length

        Return mean

    End Function

    Function CalcMedian(lengthDist As Integer()) As Double

        'variables
        Dim median, count As Integer
        Dim sum, medianLimit As Double

        sum = SumDist(lengthDist)
        medianLimit = sum / 2

        ' finding the middle value in lengthDist
        For i = 1 To lengthDist.Length

            count += lengthDist(i)

            If count >= medianLimit Then

                median = i
                Exit For

            End If

        Next

        Return median

    End Function

    Function CalcStdDev(lengthDist As Integer()) As Double

        ' variables
        Dim mean, stddev, numerator As Double

        ' initializing variables
        mean = CalcMean(lengthDist)
        numerator = 0

        ' calculating summation for numerator of stddev equation
        For i = 1 To (lengthDist.Length - 1)

            numerator += Math.Pow((lengthDist(i) - mean), 2)

        Next

        ' calculating standard deviation
        stddev = Math.Sqrt(numerator / lengthDist.Length)

        Return stddev
    End Function

    Function CalcSkewness(lengthDist As Integer()) As Double

        'variables
        Dim skewness, mean, median, stddev As Double

        ' calculating mean, median and standard deviation
        mean = CalcMean(lengthDist)
        median = CalcMedian(lengthDist)
        stddev = CalcStdDev(lengthDist)

        ' calculating skewness
        skewness = 3 * ((mean - median) / stddev)

        Return skewness

    End Function

    Function CalcQuartile(lengthDist As Integer(), quartile As Integer) As Double

        ' variables
        Dim quartileSum, quartilePercentage, distSum As Double
        Dim quartileStart, quartileEnd As Integer

        distSum = SumDist(lengthDist)
        quartileStart = (lengthDist.Length - 1) * ((quartile - 1) / 4)
        quartileEnd = (lengthDist.Length - 1) * (quartile / 4)


        ' summing quartile
        For i = quartileStart To quartileEnd

            quartileSum += lengthDist(i)

        Next

        ' getting percentage of total distribution
        quartilePercentage = quartileSum / distSum

        Return quartilePercentage

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles StartInput.Click

        ' variables
        Dim Lengths As Integer()
        Dim LengthsDist As Integer()

        ' clearing old data
        LengthBox.Items.Clear()
        DistBox.Items.Clear()
        DistGraph.Items.Clear()

        ' generating and printing lengths of each number
        Lengths = LengthsOfRange(Int(NumberInput.Text))
        PrintLengths(Lengths)

        ' generating and printing distribution of lengths
        LengthsDist = LengthDist(Lengths)
        PrintDist(LengthsDist)
        PrintDistGraph(LengthsDist)

        ' generating statistics
        MeanBox.Text = CalcMean(LengthsDist)
        MedianBox.Text = CalcMedian(LengthsDist)
        StdDevBox.Text = CalcStdDev(LengthsDist)
        SkewnessBox.Text = CalcSkewness(LengthsDist)

        Q1Box.Text = CalcQuartile(LengthsDist, 1)
        Q2Box.Text = CalcQuartile(LengthsDist, 2)
        Q3Box.Text = CalcQuartile(LengthsDist, 3)
        Q4Box.Text = CalcQuartile(LengthsDist, 4)

    End Sub

    Private Sub EndInput_Click(sender As Object, e As EventArgs) Handles EndInput.Click

        End

    End Sub

    Private Sub NumberInput_TextChanged(sender As Object, e As EventArgs) Handles NumberInput.TextChanged

        ' checking if input is empty
        If NumberInput.Text = "" Then

            ' displaying warning at over 10000
        ElseIf Int(NumberInput.Text) >= 10000 Then

            LargeNumberWarning.Visible = True

        Else

            LargeNumberWarning.Visible = False

        End If
    End Sub

End Class

