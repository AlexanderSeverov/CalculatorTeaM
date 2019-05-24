all: calc

calc: main.o test.o test1.o
	g++ main.o test.o test1.o -o calc -Wall -Werror

main.o: main.cs
	g++ -c main.cs -Wall -Werror -o build/main.o

test.o: test.cs
	g++ -c src/test.cs -Wall -Werror -o build/test.o
	
test1.o: test1.cs
	g++ -c src/test.cs -Wall -Werror -o build/test1.o
 
clean:
	rm -rf *.o geomH