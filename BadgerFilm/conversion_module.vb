﻿Module conversion_module
    Public elt_list() As String = {"H", "He", "Li", "Be", "B", "C", "N", "O", "F", "Ne", "Na", "Mg", "Al", "Si", "P", "S", "Cl", "Ar", "K", "Ca",
    "Sc", "Ti", "V", "Cr", "Mn", "Fe", "Co", "Ni", "Cu", "Zn", "Ga", "Ge", "As", "Se", "Br", "Kr", "Rb", "Sr", "Y", "Zr", "Nb", "Mo", "Tc", "Ru",
    "Rh", "Pd", "Ag", "Cd", "In", "Sn", "Sb", "Te", "I", "Xe", "Cs", "Ba", "La", "Ce", "Pr", "Nd", "Pm", "Sm", "Eu", "Gd", "Tb", "Dy", "Ho", "Er",
    "Tm", "Yb", "Lu", "Hf", "Ta", "W", "Re", "Os", "Ir", "Pt", "Au", "Hg", "Tl", "Pb", "Bi", "Po", "At", "Rn", "Fr", "Ra", "Ac", "Th", "Pa", "U",
    "Np", "Pu", "Am", "Cm", "Bk", "Cf", "Es"}

    Public Function convert_transition_num_to_Siegbahn(ByVal shell1 As Integer, ByVal shell2 As Integer) As String
        convert_transition_num_to_Siegbahn = ""
        If shell1 = 1 Then
            Select Case shell2
                Case 4
                    convert_transition_num_to_Siegbahn = "Ka1"
                Case 3
                    convert_transition_num_to_Siegbahn = "Ka2"
                Case 7
                    convert_transition_num_to_Siegbahn = "Kb"
            End Select
        ElseIf shell1 = 4 Then
            Select Case shell2
                Case 5
                    convert_transition_num_to_Siegbahn = "Ll"
                Case 9
                    convert_transition_num_to_Siegbahn = "La1"
                Case 8
                    convert_transition_num_to_Siegbahn = "La2"
            End Select
        ElseIf shell1 = 3 Then
            Select Case shell2
                Case 5
                    convert_transition_num_to_Siegbahn = "Ln"
                Case 8
                    convert_transition_num_to_Siegbahn = "Lb"
                Case 13
                    convert_transition_num_to_Siegbahn = "Lc1"
            End Select
        ElseIf shell1 = 9 Then
            Select Case shell2
                Case 16
                    convert_transition_num_to_Siegbahn = "Ma1"
                Case 15
                    convert_transition_num_to_Siegbahn = "Ma2"
            End Select
        ElseIf shell1 = 8 Then
            Select Case shell2
                Case 15
                    convert_transition_num_to_Siegbahn = "Mb"
            End Select
        ElseIf shell1 = 7 Then
            Select Case shell2
                Case 14
                    convert_transition_num_to_Siegbahn = "Mc1"
            End Select

        End If

        If convert_transition_num_to_Siegbahn = "" Then
            If shell1 = 1 Then
                convert_transition_num_to_Siegbahn = "K"
            ElseIf shell1 <= 4 Then
                convert_transition_num_to_Siegbahn = "L" & shell1 - 1
            ElseIf shell1 <= 9 Then
                convert_transition_num_to_Siegbahn = "M" & shell1 - 4
            ElseIf shell1 <= 16 Then
                convert_transition_num_to_Siegbahn = "N" & shell1 - 9
            ElseIf shell1 <= 23 Then
                convert_transition_num_to_Siegbahn = "O" & shell1 - 16
            End If

            If shell2 = 1 Then
                convert_transition_num_to_Siegbahn = "K"
            ElseIf shell2 <= 4 Then
                convert_transition_num_to_Siegbahn = convert_transition_num_to_Siegbahn & "L" & shell2 - 1
            ElseIf shell2 <= 9 Then
                convert_transition_num_to_Siegbahn = convert_transition_num_to_Siegbahn & "M" & shell2 - 4
            ElseIf shell2 <= 16 Then
                convert_transition_num_to_Siegbahn = convert_transition_num_to_Siegbahn & "N" & shell2 - 9
            ElseIf shell2 <= 23 Then
                convert_transition_num_to_Siegbahn = convert_transition_num_to_Siegbahn & "O" & shell2 - 16
            End If
        End If



    End Function

    Public Function shell_name_to_num(ByVal shell1_to_find As String) As Integer
        Select Case shell1_to_find
            Case "K"
                shell_name_to_num = 1
            Case "L1"
                shell_name_to_num = 2
            Case "L2"
                shell_name_to_num = 3
            Case "L3"
                shell_name_to_num = 4
            Case "M1"
                shell_name_to_num = 5
            Case "M2"
                shell_name_to_num = 6
            Case "M3"
                shell_name_to_num = 7
            Case "M4"
                shell_name_to_num = 8
            Case "M5"
                shell_name_to_num = 9
            Case "N1"
                shell_name_to_num = 10
            Case "N2"
                shell_name_to_num = 11
            Case "N3"
                shell_name_to_num = 12
            Case "N4"
                shell_name_to_num = 13
            Case "N5"
                shell_name_to_num = 14
            Case "N6"
                shell_name_to_num = 15
            Case "N7"
                shell_name_to_num = 16
            Case "O1"
                shell_name_to_num = 17
            Case "O2"
                shell_name_to_num = 18
            Case "O3"
                shell_name_to_num = 19
            Case "O4"
                shell_name_to_num = 20
            Case "O5"
                shell_name_to_num = 21
            Case "O6"
                shell_name_to_num = 22
            Case Else
                shell_name_to_num = 0
        End Select
    End Function

    Public Sub Siegbahn_to_transition_num(ByVal name_trans As String, ByRef shell1 As Integer, ByRef shell2 As Integer, Optional ByVal elt_name As String = "")
        shell1 = 0
        shell2 = 0

        If name_trans Like "[Kk][Aa]" Then
            If elt_name = "C" Then
                shell1 = 1
                shell2 = 3
            Else
                shell1 = 1
                shell2 = 4
            End If
        ElseIf name_trans Like "[Kk][Aa]1" Then
            shell1 = 1
            shell2 = 4
        ElseIf name_trans Like "[Kk][Aa]2" Then
            shell1 = 1
            shell2 = 3
        ElseIf name_trans Like "[Kk][Bb]" Then
            shell1 = 1
            shell2 = 7
        ElseIf name_trans Like "[Ll][Aa]" Then
            shell1 = 4
            shell2 = 9
        ElseIf name_trans Like "[Ll][Aa]1" Then
            shell1 = 4
            shell2 = 9
        ElseIf name_trans Like "[Ll][Aa]2" Then
            shell1 = 4
            shell2 = 8
        ElseIf name_trans Like "[Ll][Bb]" Then
            shell1 = 3
            shell2 = 8
        ElseIf name_trans Like "[Ll][Cc]1" Then
            shell1 = 3
            shell2 = 13
        ElseIf name_trans Like "[Ll][Nn]" Then
            shell1 = 3
            shell2 = 5
        ElseIf name_trans Like "[Ll][Ll]" Then
            shell1 = 4
            shell2 = 5
        ElseIf name_trans Like "[Mm][Aa]" Then
            shell1 = 9
            shell2 = 16
        ElseIf name_trans Like "[Mm][Aa]1" Then
            shell1 = 9
            shell2 = 16
        ElseIf name_trans Like "[Mm][Aa]2" Then
            shell1 = 9
            shell2 = 15
        ElseIf name_trans Like "[Mm][Bb]" Then
            shell1 = 8
            shell2 = 15
        ElseIf name_trans Like "[Mm][Cc]1" Then
            shell1 = 7
            shell2 = 14
        Else
            shell1 = 0
            shell2 = 0
        End If
        'Select Case name_trans
        '    Case "Ka"
        '        If elt_name = "C" Then
        '            shell1 = 1
        '            shell2 = 3
        '        Else
        '            shell1 = 1
        '            shell2 = 4
        '        End If
        '    Case "Ka1"
        '        shell1 = 1
        '        shell2 = 4
        '    Case "Ka2"
        '        shell1 = 1
        '        shell2 = 3
        '    Case "Kb"
        '        shell1 = 1
        '        shell2 = 7
        '    Case "La"
        '        shell1 = 4
        '        shell2 = 9
        '    Case "La1"
        '        shell1 = 4
        '        shell2 = 9
        '    Case "La2"
        '        shell1 = 4
        '        shell2 = 8
        '    Case "Lb"
        '        shell1 = 3
        '        shell2 = 8
        '    Case "Lc1"
        '        shell1 = 3
        '        shell2 = 13
        '    Case "Ln"
        '        shell1 = 3
        '        shell2 = 5
        '    Case "Ll"
        '        shell1 = 4
        '        shell2 = 5
        '    Case "Ma"
        '        shell1 = 9
        '        shell2 = 16
        '    Case "Ma1"
        '        shell1 = 9
        '        shell2 = 16
        '    Case "Ma2"
        '        shell1 = 9
        '        shell2 = 15
        '    Case "Mb"
        '        shell1 = 8
        '        shell2 = 15
        '    Case "Mc1"
        '        shell1 = 7
        '        shell2 = 14
        '    Case Else
        '        'MsgBox("Not found")
        '        'Stop
        '        shell1 = 0
        '        shell2 = 0
        'End Select

        'Handle the IUPAC notation, e.g., L2M3.
        If shell1 = 0 And shell2 = 0 And name_trans.Length = 4 Then
            shell1 = shell_name_to_num(name_trans(0) & name_trans(1))
            shell2 = shell_name_to_num(name_trans(2) & name_trans(3))
        End If
        'Handle the IUPAC notation for the K shell, e.g., KL3.
        If shell1 = 0 And shell2 = 0 And name_trans.Length = 3 And name_trans(0) Like "[Kk]" Then
            shell1 = 1
            shell2 = shell_name_to_num(name_trans(2) & name_trans(3))
        End If

        If shell1 = 0 And shell2 = 0 Then
            MsgBox("Unrecognized X-ray line " & name_trans)
        End If

    End Sub

    Public Function Z_to_symbol(ByVal Z As Integer) As String
        If Z > 99 Then Z = 99
        Return elt_list(Z - 1)
    End Function

    Public Function symbol_to_Z(ByVal symbol As String) As Integer
        For i As Integer = 0 To UBound(elt_list)
            If symbol Like elt_list(i) Then
                Return i + 1
            End If
        Next
        Return 0
    End Function

    'Return the correct spelling of the symbol, e.g., mg->Mg or aL->Al.
    Public Function correct_symbol(ByVal symbol As String) As String
        For i As Integer = 0 To UBound(elt_list)
            If symbol Like elt_list(i) Then
                Return elt_list(i)
            End If
        Next
        MsgBox("Element " & symbol & " not found!")
        Return symbol
    End Function

    'Table containing the atomic number, atomic weight and density (in g/cm3) of the elements of the periodic table.
    Public Function zaro(ByVal Z As Integer) As Double()
        Dim data(,) As Double = {{1, 1, 0.07},
        {2, 2, 0.000169},
        {3, 6.941, 0.533},
        {4, 9.012, 1.845},
        {5, 10.811, 2.535},
        {6, 12.011, 2.25},
        {7, 14.007, 0.001165},
        {8, 15.999, 0.001331},
        {9, 18.998, 0.001579},
        {10, 20.178, 0.0008391},
        {11, 22.988, 0.969},
        {12, 24.305, 1.735},
        {13, 26.982, 2.694},
        {14, 28.086, 2.32},
        {15, 30.974, 1.82},
        {16, 32.066, 1.953},
        {17, 35.453, 0.002947},
        {18, 39.948, 0.00166},
        {19, 39.098, 0.86},
        {20, 40.078, 1.55},
        {21, 44.956, 3.0},
        {22, 47.867, 4.54},
        {23, 50.942, 6.1},
        {24, 51.996, 7.18},
        {25, 54.938, 7.3},
        {26, 55.845, 7.86},
        {27, 58.933, 8.9},
        {28, 58.693, 8.78},
        {29, 63.546, 8.94},
        {30, 65.37, 7.115},
        {31, 69.723, 5.918},
        {32, 72.61, 5.308},
        {33, 74.922, 5.72},
        {34, 78.96, 4.82},
        {35, 79.904, 3.11},
        {36, 83.8, 0.003484},
        {37, 85.468, 1.53},
        {38, 87.62, 2.6},
        {39, 88.906, 4.45},
        {40, 91.224, 6.44},
        {41, 92.906, 8.58},
        {42, 95.94, 10.2},
        {43, 98, 11.5},
        {44, 101.07, 12.2},
        {45, 102.906, 12.39},
        {46, 106.42, 12.0},
        {47, 107.868, 10.48},
        {48, 112.411, 8.63},
        {49, 114.818, 7.3},
        {50, 118.71, 7.3},
        {51, 121.76, 6.679},
        {52, 127.6, 6.23},
        {53, 126.904, 4.92},
        {54, 131.29, 0.005458},
        {55, 132.905, 1.873},
        {56, 137.327, 3.5},
        {57, 138.906, 6.166},
        {58, 140.116, 6.771},
        {59, 140.908, 6.772},
        {60, 144.24, 7.003},
        {61, 144.913, 7.22},
        {62, 150.36, 7.537},
        {63, 151.964, 5.253},
        {64, 157.25, 7.898},
        {65, 158.925, 8.234},
        {66, 162.5, 8.54},
        {67, 164.93, 8.781},
        {68, 167.259, 9.054},
        {69, 168.934, 9.314},
        {70, 173.04, 6.972},
        {71, 174.967, 9.835},
        {72, 178.49, 13.27},
        {73, 180.948, 16.6},
        {74, 183.84, 19.3},
        {75, 186.207, 21.06},
        {76, 190.23, 22.57},
        {77, 192.217, 22.42},
        {78, 195.008, 21.41},
        {79, 196.967, 19.29},
        {80, 200.59, 13.522},
        {81, 204.383, 11.83},
        {82, 207.2, 11.33},
        {83, 208.98, 9.78},
        {84, 208.982, 9.34},
        {85, 209.987, 8.75},
        {86, 222.018, 0.000923},
        {87, 223.02, 2.5},
        {88, 226.025, 4.0},
        {89, 227.028, 10.09},
        {90, 232.038, 11.0},
        {91, 231.036, 15.4},
        {92, 238.029, 19.0},
        {93, 237.048, 19.5},
        {94, 244.064, 19.78},
        {95, 243.061, 11.7},
        {96, 247.07, 13.67},
        {97, 247.07, 14.79},
        {98, 251.08, 15.1},
        {99, 252.083, 13.5}}

        If Z < 1 Or Z > 99 Then
            MsgBox("Z out of range in zaro")
            Stop
        End If

        Return {data(Z - 1, 1), data(Z - 1, 2)}
    End Function

    Public Sub convert_wt_to_at(ByRef layer_handler() As layer, ByVal layer_num As Integer)
        Dim tot_at As Double = 0
        For i As Integer = 0 To UBound(layer_handler(layer_num).element)
            tot_at = tot_at + layer_handler(layer_num).element(i).conc_wt / zaro(symbol_to_Z(layer_handler(layer_num).element(i).elt_name))(0)
        Next

        For i As Integer = 0 To UBound(layer_handler(layer_num).element)
            layer_handler(layer_num).element(i).conc_at = layer_handler(layer_num).element(i).conc_wt /
                            zaro(symbol_to_Z(layer_handler(layer_num).element(i).elt_name))(0) / tot_at
        Next
    End Sub


    'Public Sub convert_analysis_cond_handler_to_layer_handler(ByRef analysis_cond_handler() As analysis_conditions, ByRef layer_handler() As layer, ByVal Ec_data() As String,
    '                                                          ByVal toa As Double, ByVal pen_path As String)

    '    Dim total_elts As Integer = 0
    '    For i As Integer = 0 To UBound(analysis_cond_handler)
    '        For j As Integer = 0 To UBound(analysis_cond_handler(i).elts)
    '            total_elts = total_elts + 1
    '        Next
    '    Next

    '    Dim element(total_elts - 1) As element
    '    Dim indice As Integer = 0
    '    For i As Integer = 0 To UBound(analysis_cond_handler)
    '        For j As Integer = 0 To UBound(analysis_cond_handler(i).elts)
    '            init_element(analysis_cond_handler(i).elts(j).name, analysis_cond_handler(i).elts(j).line, vbNull, analysis_cond_handler(i).elts(j).conc_wt,
    '                         Ec_data, element(indice), pen_path, i)
    '            'ReDim element(indice).k_ratio(UBound(analysis_cond_handler(i).elts(j).kratio))
    '            For k As Integer = 0 To UBound(analysis_cond_handler(i).elts(j).kratio)
    '                If analysis_cond_handler(i).elts(j).kratio_measured(k) = Nothing Or analysis_cond_handler(i).elts(j).kratio_measured(k) = 0 Then
    '                    Continue For
    '                End If
    '                If element(indice).k_ratio Is Nothing Then
    '                    ReDim element(indice).k_ratio(0)
    '                Else
    '                    ReDim Preserve element(indice).k_ratio(UBound(element(indice).k_ratio) + 1)
    '                End If
    '                element(indice).k_ratio(UBound(element(indice).k_ratio)).kv = analysis_cond_handler(i).elts(j).energy_analysis(k)
    '                element(indice).k_ratio(UBound(element(indice).k_ratio)).measured_value = analysis_cond_handler(i).elts(j).kratio_measured(k)
    '                element(indice).k_ratio(UBound(element(indice).k_ratio)).std = analysis_cond_handler(i).elts(j).std_filename(k)
    '            Next
    '            indice = indice + 1
    '        Next
    '    Next


    '    indice = 0
    '    ReDim layer_handler(UBound(analysis_cond_handler)) 'As layer
    '    For i As Integer = 0 To UBound(analysis_cond_handler)
    '        ReDim layer_handler(i).element(UBound(analysis_cond_handler(i).elts))
    '        For j As Integer = 0 To UBound(analysis_cond_handler(i).elts)
    '            layer_handler(i).element(j) = element(indice)
    '            indice = indice + 1
    '        Next

    '        layer_handler(i).density = analysis_cond_handler(i).density
    '        layer_handler(i).id = i
    '        layer_handler(i).thickness = analysis_cond_handler(i).thickness
    '        layer_handler(i).mass_thickness = layer_handler(i).density * layer_handler(i).thickness * 10 ^ -8
    '    Next
    'End Sub
End Module