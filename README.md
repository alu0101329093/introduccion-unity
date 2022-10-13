# Introduccion Unity

## Explicación
Primero se han creado los tres objetos básicos(esfera, cubo y plano). Tras añadir los paquetes `Starter Assets` y `Ball Pack`, se añade el prefab `NestedParentArmature_Unpack` para tener un personaje que se pueda mover y una cámara que lo siga. Ahora ocultamos la `Geometry` del `PlayerArmature` para poder poner `WheelBall` del paquete `Ball Pack` como personaje. Si se quiere la hitbox del personaje sea igual que la bola se debera modificar el `Radius`, `Center` y `Height` hasta que encaje. Por último, se crea un script, que añadiremos a nuestros objetos, que permita recibir un nombre como propiedad pública y luego en el `Update` de este se usa un `Debug.Log` para mostrar el nombre asignado.

## Ejemplo de Uso
![Playing the game in Unity](/unity-play.gif)
