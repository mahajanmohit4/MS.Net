   M S B A M L   `   `   `  ����G  CDatabaseDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:DatabaseDemoDatabaseDemo  5   	       DatabaseDemo.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:DatabaseDemo     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� $��EmpNO��6   $
��Left=�6    $��	51,58,0,0q�6;   $	��Top=�6N   �� 5   
   $
��Name��6   $
��Left=�6   $��
51,111,0,0q�6:   $	��Top=�6N   �� 5   
   $��Basic��6   $
��Left=�6    $��
51,170,0,0q�6;   $	��Top=�6O    J� RenderTransformOrigin$ -0.186,-0.511&�6g   �� 5   
   $��DeptNo��6   $
��Left=�6!   $��
51,231,0,0q�6<   $	��Top=�6P   �� 5   
   -   5         ��Name$ txtEmpNo��5      $
��Left=�6$   $��
207,58,0,0q�6?    �� TextWrapping$
 Wrap=�6S   $	��Top=�6g   $	��120��6   �� 5   
   -   5        $ txtName��5      $
��Left=�6#   $��207,115,0,0q�6>   $
 Wrap=�6S   $	��Top=�6g   $	��120��6   �� 5   
   -   5        $ txtBasic��5      $
��Left=�6$   $��207,170,0,0q�6?   $
 Wrap=�6T   $	��Top=�6h   $	��120��6�   �� 5   
   -   5        $ 	txtDeptNo��5      $
��Left=�6%   $��207,235,0,0q�6@   $
 Wrap=�6U   $	��Top=�6i   $	��120��6�   �� 5   
   -   5         ��Name$ 	btnInsert��5      $��Insert��6$   $
��Left=�65   $��
96,298,0,0q�6P   $	��Top=�6d   $��94��6|   6�   �� 5   
   -   5        $��Insert with Parameters��5      $
��Left=�62   $��299,298,0,0q�6M   $	��Top=�6b   $	��232��6z   6�   �� 5   
   -   5        $"��Insert with Stored Procedure��5      $
��Left=�68   $��
96,341,0,0q�6S   $	��Top=�6g   $	��319��6   6�   �� 5   
   -   5        $��Transaction��5      $
��Left=�6'   $��131,387,0,0q�6B   $	��Top=�6W   $	��226��6o   6{   �� 5   
   -	   5        $��ExecuteQuery��5      $
��Left=�6(   $��496,387,0,0q�6C   $	��Top=�6X   $	��141��6p   6|   5      5      