   M S B A M L   `   `   `  ����L  HExaminationSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ExaminationSystemExaminationSystem  5   	   $    ExaminationSystem.CourseTopics   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:ExaminationSystem     5   	   -   5          � Title$  CourseTopics��5	   	   $	��450��6   $	��800��6+   .��5
      �� .+�5   
   �� -   5        $��fullName��5      $��29��5       �� TextWrapping$
 Wrap=�5      $��	Wlcome : ��5      $��	0,0,586,0q�5      �� 5   
   -   5        $
��Back��5      $��38��6     J� RenderTransformOrigin$ -1.176,0.564&�6,   $��
688,0,30,0q�6Q   6e   �� 5   
   $��Course Topics ��6   $��Center=�5      $��Center=�5      $��10 10 10 15q�5      $��18(�5      $
��Bold"�5      $��Georgia)�5      � 5   
   $��10 10 10 30q�6    � ColumnDefinitions 5      �� 5      �� 5      .+�5      � $��0��6    5      �� 5      $	��99* �6'   �� 5       $	��99* �6'   �� 5!      $	��32* �6'   .+�5#      �� $��85��5$      $��30��5%      $��15(�5&      $
��Bold"�5'      $��Georgia)�5(      $
��Left=�5)      $��	15,4,0,-4q�5*      $ 	0.3,3.077&�5+      $��0��5,      $��Course :��6%   5-      �� 5.      -   5         ��Name$ Course_Topics��5/      $��15(�50      $
��Bold"�51      $��Georgia)�52       �� DisplayMemberPath$ crs_Name��53       �� SelectedValuePath$ crs_id��54      $	��200��57      $��30��58      $
��Left=�59      $��Center=�5:      $��
110,5,0,-6q�5;      $��2��5<      �� 5=      -   5        $��1��5=      $��15(�5>      $
��Bold"�5?      $��Georgia)�5@      $	��150��5A      $
��View��5B   3   5C      &   System.Windows.Controls.DataGrid  5D   
   -   5          Name$ CoursesTopicsList��5D         AutoGenerateColumns .  $��171,10,163.6,10q�5E      	   Columns	 5F      0  *System.Windows.Controls.DataGridTextColumn  5G      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Course��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 221 5H   %   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5J   %   �� *
crs_name+  5L      $
 Topics��6%   $	 221 5M   %    5N   %   �� *Topics+5P      5Q      5R      