修改emacs主题：M-x load-theme Tab
git生成公钥私钥： ssh-keygen -t rsa -C "youremail@example.com"
公钥私钥储存路径： /root/.ssh/pub
隐藏gome顶栏：/usr/share/gnome-shell/theme/gnome-classic.css
	TOP BAR 字段 height：1.86em
deb转rpm：
首先需要安装alien工具：http://ftp.de.debian.org/debian/pool/main/a/alien/
[root@localhost tmp]#tar zxvf alien_8.88.tar.gz
[root@localhost alien]#perl Makefile.PL
[root@localhost alien]#make
[root@localhost alien]#make instal
[root@localhost alien]#yum -y install rpm-build
[root@Master Downloads]# alien -r libbz2-dev_1.0.6-5_i386.deb 
libbz2-dev-1.0.6-6.i386.rpm generated
[root@Master Downloads]# rpm -ivh libbz2-dev-1.0.6-6.i386.rpm 
------------------------------------------------------------------------------------------------
可能会报错
[root@localhost alien]#yum -y install python-libs python-wnck
