   M S B A M L   `   `   `  ����L  HExaminationSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ExaminationSystemExaminationSystem  5   	   &     ExaminationSystem.StudentResults   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:ExaminationSystem     5   	   -   5          � Title$  StudentResults��5	   	   $	��450��6    $	��800��6-   .��5
      �� .+�5   
   �� -   5        $
��Back��5      $��38��5      $��60��5      $	��Top=�5      $��Right=�5      $��0,0,14,0q�5      5      �� 5   
   -   5        $��studentName��5      $��29��5       �� TextWrapping$
 Wrap=�5      $��
Welcome : ��5      $	��200��5      $	��Top=�5      $
��Left=�5      $��	0,-30,0,0q�5      �� 5   
   $��Student Results��6   $��Center=�5      $��Right=�5      $��0,10,318,15q�5      $��18(�5      $
��Bold"�5      $��Georgia)�5       � 5!   
   $��10 10 10 30q�6    � ColumnDefinitions 5"      �� 5#      �� 5$      .+�5&      � $��0��6    5(      �� 5)      $	��99* �6'   �� 5*      $	��99* �6'   �� 5+      $	��32* �6'   .+�5-      �� $��85��5.      $��30��5/      $��15(�50      $
��Bold"�51      $��Georgia)�52      $
��Left=�53      $��	15,4,0,-4q�54       J� RenderTransformOrigin$ 	0.3,3.077&�55      $��0��56      $��	Subject :��6%   �� 57      -   5         ��Name$ 
std_result��58      $��15(�59      $
��Bold"�5:      $��Georgia)�5;       �� DisplayMemberPath$ crs_Name��5<       �� SelectedValuePath$ grade��5=      $	��200��5>      $��30��5?      $
��Left=�5@      $��Center=�5A      $��
110,5,0,-6q�5B      $��2��5C      5E      �� 5G      -   5        $��1��5G      $��15(�5H      $
��Bold"�5I      $��Georgia)�5J      $	��150��5K      $
��View��5L   0   5M      &   System.Windows.Controls.DataGrid  5O   
   -   5          Name$ StudentGradeResults��5O         AutoGenerateColumns .  $	��450��5P      $��Center=�5Q      $��20 10 20 10q�5R      	   Columns	 5S      0  *System.Windows.Controls.DataGridTextColumn  5U      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Subject��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 221 5V   %   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5X   %   �� *	Subject+  5Z      $
 Grade��6%   $	 221 5[   %    5\   %   �� *Grade+5`      5a      5b      