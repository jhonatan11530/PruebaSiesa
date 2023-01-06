# Prueba tecnica de Siesa 2022

------------------------------------
### Lenguaje usado C# se uso el .NET FRAMEWORK 4.5
------------------------------------
### Descripcion de la Solucion Punto #1

El metodo ConvertToBase2 es una función que convierte un número de base 10 a base 2. Esto se logra mediante un ciclo while que itera mientras el número sea mayor que cero. En cada iteración, se obtiene el residuo de la división del número por 2 y se concatena al resultado final. Luego, se divide el número entero por 2 y se actualiza su valor.

Cuando el ciclo termina, el resultado final es la representación en base 2 del número original. Este resultado se devuelve como una cadena de caracteres.

Por ejemplo, si queremos convertir el número 10 de base 10 a base 2, el método funcionaría de la siguiente manera:

1. La variable number tiene el valor 10 y la variable result está vacía.
2. El residuo de la división de 10 entre 2 es 0, entonces se concatena "0" al resultado final. El cociente de la división es 5.
3. La variable number se actualiza a 5.
4. El residuo de la división de 5 entre 2 es 1, entonces se concatena "1" al resultado final. El cociente de la división es 2.
5. La variable number se actualiza a 2.
6. El residuo de la división de 2 entre 2 es 0, entonces se concatena "0" al resultado final. El cociente de la división es 1.
7. La variable number se actualiza a 1.
8. El residuo de la división de 1 entre 2 es 1, entonces se concatena "1" al resultado final. El cociente de la división es 0.
9. La variable number es igual a 0, entonces el ciclo termina.
10. El resultado final es "1010", que es la representación en base 2 del número 10.

### Descripcion de la Solucion Punto #2
