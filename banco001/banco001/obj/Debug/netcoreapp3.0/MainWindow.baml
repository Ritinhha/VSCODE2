   M S B A M L   `   `   `  ����C  ?banco001, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:banco001banco001  5   	       banco001.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:banco001     5   	     � Title$  cliente��5   	   $	��479��6   $	��805��6&   .��5	      � $��0,0,0,14q�6    � ColumnDefinitions 5
   
   �� 5      $
��199* �6   �� 5      .+�5   
   �� $
��Left=�6   $��	10,10,0,0q�6/   $��Banco��6B   $
��Wrap=�6O   $	��Top=�6c   $��40(�6{   $��53��6�   $	��113��6�   �� 5   
   -   5         ��Name$ 	nomebanco��5      $
��Left=�6%   $��
13,102,0,0q�6@    �� TextWrapping$
 Wrap=�6T   $	��Top=�6h   $	��361��6�   $��24��6�   �� 5   
   -   5        $ numerobanco��5      $
��Left=�6'   $��24��6B   $��400,102,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��155��6�   �� 5   
   -   5        $ 	tellbanco��5      $
��Left=�6%   $��25��6@   $��585,101,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��196��6�   �� 5   
   -   5         ��Name$ inserirbanco��5      $��Inserir��6'   $
��Left=�69   $��37��6T   $��
12,146,0,0q�6`   $	��Top=�6t   $	��120��6�   6�   �� 5   
   -   5        $ cadastraclientenobanco��5      $��Cadastra cliente no banco��61   $
��Left=�6U   $��37��6p   $��400,145,0,0q�6|   $	��Top=�6�   $	��155��6�   6�   �� 5   
   $
��Left=�6   $��	14,78,0,0q�6/   $
��Wrap=�6B   $	��Top=�6V   $��15(�6n   $��20��6|   $��41��6�   �� 6�    � Language$ pt-br�6�   $
�Nome��6�   6�   �� 5   
   $
��Left=�6   $��
400,77,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   $��15(�6o   $��20��6}   $��66��6�   �� 6�   $ pt-br�6�   $�Número��6�   6�   �� 5   
   $
��Left=�6   $��
585,77,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   $��15(�6o   $��20��6}   $��22��6�   �� 6�   $ pt-br�6�   $
�Tell��6�   6�   �� 5   
   -   5        $ bancos��5      $��Listar bancos��6!   $
��Left=�69   $��585,146,0,0q�6T   $	��Top=�6i   $��37��6�   $	��196��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
listabanco��5      $��14,228,20,10q�6'      
IsReadOnly$
 True��6=      SelectionMode$ Single=�6O   6f   �� 5   
   $
��Left=�6   $��
12,203,0,0q�6/   $��Clientes do banco��6C   $
��Wrap=�6\   $	��Top=�6p   $��15(�6�   $��20��6�   $	��119��6�   �� 5   
   -   5        $ atualizarbanco��5      $��	Atualizar��6)   $
��Left=�6=   $��151,144,0,0q�6X   $	��Top=�6m   $	��101��6�   $��38��6�   6�   �� 5   
   -	   5        $��Excluir��5      $
��Left=�6#   $��274,145,0,0q�6>   $	��Top=�6S   $��37��6k   $	��100��6w   6�   5      5      