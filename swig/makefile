all:
	swig -c++ -csharp ss_oled.i 
	g++ -c -fPIC -D_LINUX_ ../linux/ss_oled.c ../src/ss_oled.cpp ss_oled_wrap.cxx
	g++ -shared ../linux/ss_oled.o ss_oled_wrap.o ../../BitBang_I2C-2.2.1/linux/BitBang_I2C.o -lpigpio -o libss_oled.so
	

clean:
	rm *.o *.cs *.cxx *.so
