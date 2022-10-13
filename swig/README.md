## Build C# wrapper

This requires that [Bitbang_I2C](https://github.com/bitbank2/BitBang_I2C) is checkout and compiled in a directory parallel to ss_oled.

Steps:

1. Build BitBang_I2C by running `make` in the projects linux folder. This produces a `BitBang_I2C.o` file
2. Build ss_oled by running `make` in the projects linux folder.
3. Build ss_oled examples by running `make -f make_sample`
4. Now you can test your build by executing the `sample` file in `linux/` 
5. Install Swig (sudo apt install swig)
6. In this folder execute `make` - which should create a `.so` file
7. Copy `.cs` files into the dotnet solution folder.
8. Make sure the pins are the same as in the solution.
