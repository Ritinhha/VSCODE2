   M S B A M L   `   `   `  ����C  ?banco001, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:banco001banco001  5   	       banco001.Window1   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:banco001     5   	     � Title$  Banco��5   	   $	��497��6   $	��569��6$   .��5
      � $��Center=�6   $	��564��6(   $��	0,10,0,-6q�64   .+�5   
   �� -   5         ��Name$ nomecliente��5      $
��Left=�6'   $��28��6B   $��	15,93,0,0q�6N    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��281��6�   �� 5   
   -   5        $ 
cpfcliente��5      $
��Left=�6&   $��28��6A   $��
329,90,0,0q�6M   $
 Wrap=�6a   $	��Top=�6u   $	��209��6�   �� 5   
   -   5        $ datanascimento��5      $
��Left=�6*   $��28��6E   $��
15,153,0,0q�6Q   $
 Wrap=�6e   $	��Top=�6y   $	��155��6�   �� 5   
   -   5        $
 tell��5      $
��Left=�6    $��28��6;   $��205,151,0,0q�6G   $
 Wrap=�6\   $	��Top=�6p   $	��333��6�   �� 5   
   -   5         ��Name$ fffdf��5      $
��Left=�6#   $��	15,66,0,0q�6>   $
��Nome��6Q   $
��Wrap=�6]   $	��Top=�6q   $��15(�6�   �� 5   
   $
��Left=�6   $��
15,133,0,0q�6/   $��Data de Nascimento��6C   $
��Wrap=�6]   $	��Top=�6q   $��15(�6�   �� 5   
   $
��Left=�6   $��
327,70,0,0q�6/   $	��CPF��6C   $
��Wrap=�6N   $	��Top=�6b   $��15(�6z   �� 5   
   $
��Left=�6   $��203,131,0,0q�6/   $
��Tell��6D   $
��Wrap=�6P   $	��Top=�6d   $��15(�6|   �� 5   
   $
��Left=�6   $��24,6,0,0q�6/   $
��Wrap=�6A   $	��Top=�6U   $��40(�6m   $	��424��6{   �� 6�   $�Cadastro��6�   �� 6�   $
�  do��6�   �� 6�    � Language$ pt-br�6�   $� Cliente��6�   �� 6�   $� ��6�   6�   �� 5   
   -   5         ��Name$ cadastraclientenaconta��5      $��Gerenciar Contas��61   $
��Left=�6L   $��415,196,0,0q�6g   $	��Top=�6|   $��37��6�   $	��123��6�   6�   �� 5   
   -   5        $ excluircliente��5      $��Excluir��6)   $
��Left=�6;   $��242,197,0,0q�6V   $	��Top=�6k   $��35��6�   $��66��6�   6�   �� 5   
   -   5        $ inserircliente��5      $��Inserir��6)   $
��Left=�6;   $��
29,197,0,0q�6V   $	��Top=�6j   $��35��6�   $��72��6�   6�   �� 5   
   -	   5        $ atualizarcliente��5      $��	Atualizar��6+   $
��Left=�6?   $��137,197,0,0q�6Z   $	��Top=�6o   $��35��6�   $��70��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -
   5          Name$ listaClientes��5      $��11,289,25,16q�6*      
IsReadOnly$
 True��6r   �� 5   
   $
��Left=�6   $��
15,259,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   $��15(�6o   �� 6~   $ pt-br�6�   $�Clientes��6�   6�   5      5      