   M S B A M L   `   `   `  ����E  APerpusDong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:PerpusDong.ViewPerpusDong.View  5   	   $    PerpusDong.View.DaftarBukuPage   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:PerpusDong.View     5   	     � Title$  DaftarBukuPage��5   	   $	��450��6    $	��800��6-   
����d�.��5	      � .+�5
   
   �� 
������� J� Opacity$	 0.7Q�6$   $��	0,0,0,355q�62   .+�5      �� -   5         ��Name$ 
btnKembali��5      $��50��6)   $��12(�64   
������� �� Left$ 10��6U   
 �� Top$ 10��6f   $��44��6v   .��5      �� $��..\\Image\93634.png��6   $��Center=�65   5      5      �� 5   
   
�������$��10,122,10,10q�6$   .+�5      �� $��10,10,10,10q�6   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ dgDaftarBuku��5      dgDaftarBuku��$
��auto��6^      AutoGenerateColumns .   �� SelectedIndex$ 0��6�   $	��701��6�   ��6F   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 	Kode Buku��6I   
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 100 6\   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6-   �� *	kd_buku+6\     5      $
	 Nama��6K   $	
 100 6Y    6-   �� *	nama_buku+6Y     5      $	 Tahun��6L   $	
 100 6[    6-   �� *
tahun_buku+6[     5      $	 Bahasa��6M   $	
 100 6]    6-   �� *bahasa_buku+6]     5      $	 	Pengarang��6P   $	
 100 6c    6-   �� *pengarang_buku+6c     5      $	 Penerbit��6O   $	
 100 6a    6-   �� *penerbit_buku+6a     5      $	 Harga��6L   $	
 100 6[    6-   �� *
harga_buku+6[   5      5      5      �� 5   
   -   5         ��Name$ lblBuku1��5      $
��Buku��6"   
���   �$��26(�5      $��Medium"�6   $��Center=�62   $��262,10,262,355q�6O   �� 5    
   -   5        $ btnInputBuku��5       $��
Input Buku��6'   $��Center=�6<   $��107,102,588,0q�6Y   $	��Top=�6p   $��97��6�   
����  �$��12(�6�   $
��Bold"�6�   
�������6�   �� 5!   
   -   5        $ btnDaftarBuku��5!      $��Daftar Buku��6(   $��Center=�6>   $��10,102,685,0q�6[   $	��Top=�6q   $��97��6�   
����  �$��12(�6�   $
��Bold"�6�   
�������6�   5"      5#      