   M S B A M L   `   `   `  ����L  HExaminationSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ExaminationSystemExaminationSystem  5   	   )    #ExaminationSystem.ViewCoursesWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:ExaminationSystem     5   	   -   5          � Title$  ViewCoursesWindow��5	   	   $	��450��6#   $	��800��60   .��5
      �  � ColumnDefinitions 5   
   �� 5      $��3* �6   �� 5      $��0 �6   �� 5      $��8* �6   .+�5   
   �� $��
My Courses��6   $��57��6%   $��110.2,27,0,0q�61   $	��Top=�6G   $	��327��6_   $��24(�6k   $
��Left=�6y   $
��Bold"�6�   $��2��6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��Ins_Crs_Grid��5      $
��Left=�6'   $	��234��6B   $��173,107,0,0q�6O   $	��Top=�6d   $	��481��6|   $��3��6�   �� 5   
   -   5        $
��Back��5      $
��Left=�6    $	��Top=�6;   $��75��6S   $��2��6^   $��
442,12,0,0q�6n   6�   �� 5   
   -   5        $��instructorName��5      $
��Left=�5      $��23��5      $��10,9,0,0q�5       �� TextWrapping$
 Wrap=�5      $��
Welcome : ��5      $	��Top=�5      $	��176��5      5      5      