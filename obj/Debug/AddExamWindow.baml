   M S B A M L   `   `   `  ����L  HExaminationSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ExaminationSystemExaminationSystem  5   	   %    ExaminationSystem.AddExamWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:ExaminationSystem     5   	   -   5          � Title$  AddExamWindow��5	   	   $	��450��6   $	��800��6,   .��5
      � .+�5   
   �� $��Add Exam��6   $
��Left=�6#   $	��Top=�6>   $��
339,24,0,0q�6V   $��24(�6j   $
��Bold"�6x   �� 5   
   -   5        $��
combox_crs��5       �� DisplayMemberPath$ crs_name��6%    �� SelectedValuePath$ crs_Id��5      $
��Left=�5      $��339,105,0,0q�6.   $	��Top=�6C   $	��190��6[   $��35��6g   �� 5   
   $��Course:��6   $
��Left=�6"   $��38��6=   $��103,105,0,0q�6I   $	��Top=�6^   $	��125��6v   $��18(�6�   �� 5   
   $��No. of MCQ:��6   $
��Left=�6&   $��38��6A   $��103,161,0,0q�6M   $	��Top=�6b   $	��125��6z   $��18(�6�   �� 5   
   $��No. of T/F:��6   $
��Left=�6&   $��38��6A   $��103,217,0,0q�6M   $	��Top=�6b   $	��125��6z   $��18(�6�   �� 5   
   $��	Duration:��6   $
��Left=�6$   $��38��6?   $��103,274,0,0q�6K   $	��Top=�6`   $	��125��6x   $��18(�6�   �� 5   
   -   5        $��btn_add_exam��5      $	��Add��6%   $
��Left=�63   $��51��6N   $��614,334,0,0q�6Z   $	��Top=�6o   $	��112��6�   $��20(�6�   $
��Bold"�6�   6�   �� 5   
   -   5        $��
txtbox_mcq��5      $
��Left=�6$   $��38��6?   $��339,161,0,0q�6K    �� TextWrapping$
 Wrap=�6`   $	��Top=�6t   $	��190��6�   �� 5   
   -   5        $��	txtbox_tf��5      $
��Left=�6#   $��38��6>   $��339,217,0,0q�6J   $
 Wrap=�6_   $	��Top=�6s   $	��190��6�   �� 5   
   -   5        $��txtbox_duration��5      $
��Left=�6)   $��38��6D   $��339,274,0,0q�6P   $
 Wrap=�6e   $	��Top=�6y   $	��190��6�   �� 5   
   -   5        $
��Back��5      $	��Top=�6    $��693,10,24,0q�68   6M   �� 5   
   -   5         ��Name$ insName��5      $��23��5      $��10,11,662,0q�5      $
 Wrap=�5      $��	Welcoe : ��5      $	��Top=�5      5      5       