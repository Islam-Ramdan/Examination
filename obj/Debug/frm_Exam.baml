   M S B A M L   `   `   `  ����L  HExaminationSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ExaminationSystemExaminationSystem  5   	        ExaminationSystem.frm_Exam   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:ExaminationSystem     5   	   -   5          � Title$  frm_Exam��5	   	   $	��450��6   $	��800��6'   .��5
      � -   5         �Name$ grd_Exam��5
      .+�5   
   �� -   5         ��Name$ 
btn_Submit��5      $��Submit��6%   $
��Left=�66   $��662,372,0,0q�6Q   $	��Top=�6f   $��96��6~   $��27��6�   6�   �� 5   
   -   5        $ btn_Next��5      $	��❯��6#   $	��Top=�6/   $��Center=�6N   $��Right=�6r   $��0,145,0.333,0q�6�   $	��Top=�6�   $��75��6�   $	��112��6�   
������ $��0q�6�   $��75(�6   J� RenderTransformOrigin$ 
4.151,0.44&�6'  �� 5   
   -   5        $ btn_Previous��5      $	��❮��6'   $	��Top=�63   $��Center=�6R   $
��Left=�6v   $��	0,145,0,0q�6�   $	��Top=�6�   $��75��6�   $	��112��6�   
������ $��0q�6�   $��75(�6  6  �� 5   
   -   5         ��Name$ lbl_QNum��5      $��Question (1) out of (10)��6"   $
��Left=�6E   $��	34,21,0,0q�6`   $	��Top=�6s   �� 5   
   -   5        $ 	lbl_Timer��5      $��Time - 00:00:00��6#   $
��Left=�6=   $��
667,21,0,0q�6X   $	��Top=�6l   �� 5   
   -   5         ��Name$ txb_Question��5      $
��Left=�6*   $��	75,65,0,0q�6E   $
��Wrap=�6X    �� TextAlignment$ Justify=�6l   $��Question description��6�   $	��Top=�6�   $��80��6�   $	��628��6�   	� 5   
   -	   5         	�Name$ 
rd_Choice1��5      $��
75,165,0,0q�6*   $	��Top=�6>   $��35��6s   $
��Left=�6   $	��628��6�   .��5      �� -
   5        $ txb_Choice1��5      $
��Wrap=�6-   $ Justify=�6A   $��txb_Choice1��6Y   5      	� 5   
   -   5        $ 
rd_Choice2��5      $��
75,219,0,0q�6*   $	��Top=�6>   $��35��6s   $
��Left=�6   $	��628��6�   .��5      �� -   5        $ txb_Choice2��5      $
��Wrap=�6-   $ Justify=�6A   $��txb_Choice2��6Y   5      	� 5   
   -   5        $ 
rd_Choice3��5      $��
75,270,0,0q�6*   $	��Top=�6>   $��35��6s   $
��Left=�6   $	��628��6�   .��5      �� -   5        $ txb_Choice3��5      $
��Wrap=�6-   $ Justify=�6A   $��txb_Choice3��6Y   5      	� 5   
   -   5        $ 
rd_Choice4��5      $��
75,324,0,0q�6*   $	��Top=�6>   $��35��6s   $
��Left=�6   $	��628��6�   .��5      �� -   5        $ txb_Choice4��5      $
��Wrap=�6-   $ Justify=�6A   $��txb_Choice4��6Y   5       5"      5#      