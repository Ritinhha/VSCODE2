   M S B A M L   `   `   `  ����C  ?banco001, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:banco001banco001  5   	       banco001.Window2   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:banco001     5   	     � Title$  Conta��5   	   $	��400��6   $	��456��6$   .��5	      � $��0,0,0,-6q�6   .+�5
   
   �� $
��Left=�6   $��50��6/   $��	20,10,0,0q�6;   $��Conta��6N   $
��Wrap=�6[   $	��Top=�6o   $	��118��6�   $��40(�6�   �� 5   
   -   5         ��Name$ saldo��5      $
��Left=�6!   $��312,111,0,0q�6<    �� TextWrapping$
 Wrap=�6Q   $	��Top=�6e   $	��125��6}   $��29��6�   �� 5   
   -   5         ��Name$ inserirconta��5      $��Inserir��6'   $
��Left=�69   $��
22,159,0,0q�6T   $	��Top=�6h   $	��117��6�   $��37��6�   6�   �� 5   
   -   5         ��Name$ IDCONTA��5      $
��Left=�6%   $��	20,87,0,0q�6@   $
��Wrap=�6S   $	��Top=�6g   $��15(�6   �� 6�    � Language$ pt-br�6�   $�Cliente��6�   6�   �� 5   
   -   5        $ IDCONTA_Copy��5      $
��Left=�6*   $��
163,89,0,0q�6E   $
��Wrap=�6Y   $	��Top=�6m   $��15(�6�   $	��120��6�   �� 6�   $ pt-br�6�   $�Banco��6�   6�   �� 5   
   -   5        $ IDCONTA_Copy1��5      $
��Left=�6+   $��
312,87,0,0q�6F   $
��Wrap=�6Z   $	��Top=�6n   $��15(�6�   $��48��6�   �� 6�   $ pt-br�6�   $�Saldo��6�   6�   �� 5   
   -   5        $ atualizarconta��5      $��	Atualizar��6)   $
��Left=�6=   $��163,159,0,0q�6X   $	��Top=�6m   $��37��6�   $	��120��6�   6�   �� 5   
   -   5        $ excluirconta��5      $��Excluir��6'   $
��Left=�69   $��312,159,0,0q�6T   $	��Top=�6i   $	��125��6�   $��37��6�   6�   �� 5   
   -   5         ��Name$ clienteLista��5      $
��Left=�6)   $��
18,115,0,0q�6D   $	��Top=�6X   $	��120��6p   �� 5   
   -	   5        $ 
bancoLista��5      $
��Left=�6'   $��163,114,0,0q�6B   $	��Top=�6W   $	��120��6o   &   System.Windows.Controls.DataGrid  5   
   -
   5          Name$ contasLista��5      $��10,244,12,22q�6(      
IsReadOnly$
 True��6>   6P   �� 5   
   -   5        $ IDCONTA_Copy2��5      $
��Left=�6+   $��
10,219,0,0q�6F   $
��Wrap=�6Z   $	��Top=�6n   $��15(�6�   �� 6�   $ pt-br�6�   $�Contas��6�   6�   5      5      