   M S B A M L   `   `   `  ����L  HExaminationSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ExaminationSystemExaminationSystem  5   	   #    ExaminationSystem.StudentExam   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:ExaminationSystem     5   	   -   5          � Title$  StudentExam��5	   	   $	��450��6   $	��800��6*   .��5
      �� .+�5   
   �� -   5        $
��Back��5      $��32��5      $	��Top=�5      $
��Left=�5      $��	730,0,0,0q�5   &   $��52��69   �� 5   
   -   5        $��
studetName��5      $��28��5       �� TextWrapping$
 Wrap=�5      $��
Welcome : ��5      $	��176��5      $	��Top=�5      $
��Left=�5      $��	0,-30,0,0q�5      �� 5   
   $��Center=�5      $��Georgia)�5      $
��Bold"�5      $��18(�5      $��329,20,285.6,20q�5      $��Review Exam��6&   � 5   
    � ColumnDefinitions 5      �� 5       �� 5!      �� 5"      .+�5%      � $��0��6   $��15 10 10 15q�5&       5'      �� 5(      �� 5)      .+�5+      �� $��0��5,      $��	Subject :��5-      �� 5.      -   5         ��Name$ subjectCombo��5/      $��1��5.       �� DisplayMemberPath$ crs_Name��50       �� SelectedValuePath$ crs_Id��51      $	��120��53      $��
-100 0 0 0q�54      55      � 57      $��1��6   $��15 10 10 15q�58       59      �� 5:      �� 5;      .+�5=      �� $��0��5>      $��Exam :��5?      �� 5@      -   5        $ 	examCombo��5D      $��1��5@      $ exam_id��5A      $ exam_id��5B      $	��120��5E      $��
-100 0 0 0q�5F      5G      �� 5I      -   5         ��Name$ examInfo��5N      $��2��5J      $��10 10 20 15q�5K      $	��100��5L      $
��View��5M      5O      5P      &   System.Windows.Controls.DataGrid  5R   
   -   5          Name$ examContainer��5R         AutoGenerateColumns .  $	��510��5S      $��Center=�5T      $��20 10 20 10q�5U      	   Columns	 5V      0  *System.Windows.Controls.DataGridTextColumn  5W      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Question��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 350 5X   %   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5Z   %   �� *qDescription+  5\      $
 Student Answer��6%   $	 150 5]   %    5^   %   �� *choice+5`      5a      5b      