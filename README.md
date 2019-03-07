# Demo-Haptico-Phantom-Omni-RM

Proyecto desarrollado como parte de la clase de Desarrollo de Aplicaciones Móviles en Realidad Mixta de la Universidad de Los Andes.

Este demo se realizó en base a las escenas de ejemplo que vienen junto al plugin de Unity para utilizar los dispositivos de interacción háptica Phantom Omni desarrollado por Geomagic. El plugin puede ser encontrado en: https://assetstore.unity.com/packages/essentials/tutorial-projects/unity-5-haptic-plugin-for-geomagic-openhaptics-3-3-hlapi-hdapi-34393 

## Instrucciones de instalación

- Antes de ejecutar el demo el dispositivo Phantom Omni debe estar correctamente conectado y configurado en el computador. (Para comprobar el funcionamiento de los Phantom Omni es posible probarlos al ejecutar el programa "Phantom_Test", el cual es un programa que viene incluido con los Phantom Omni y debió haber sido instalado al configurarlos por primera vez).
- Clonar el repositorio.
- Abrir el proyecto en Unity.
- Ir a la carpeta Assets > Haptic Project Components > Scene > Haptic Demo
- Abrir la escena llamada "Haptic Demo".
- Hacer el Build And Run del proyecto. (Para esto se puede utilizar el comando Ctrl + B o en el menú File > Build And Run).

Nota: La ejecución del demo puede hacerse únicamente a través de la opción Build And Run ya que al ejectuar la escena desde Unity (al dar click en el botón Play en la escena) se genera un error.


## Descripción de la extensión desarrollada:

El demo que desarrollé es un juego simple que se basa en la interacción háptica con objetos virtuales de diferentes características. 

En el juego se muestran 5 objetos de madera de diferentes dimensiones y diferente masa, y el objetivo es colocar todos los objetos en una plataforma antes de que se acabe el tiempo. Así, una vez el tiempo termina el suelo en donde descansan los objetos desaparece, por lo que si el usuario no logró colocar todos los objetos en la plataforma estos caerán y el juego terminará.

De esta forma el usuario interactúa con objetos virtuales de diferentes dimensiones y distinta masa a través de los dispositivos de interacción háptica Phantom Omni. 

Para el desarrollo de la escena del juego me basé en las escenas de ejemplo que venían con el plugin en las cuáles se mostraban ejemplos de interacción con objetos de diferentes texturas y algunos de diferente masa. De esta forma, partí de los scripts desarrollados en el plugin para extenderlos de tal forma que se generaran objetos de diferente masa y deferentes dimensiones (ambos valores aleatorios) en una escena, y de manera similar realicé las modificaciones para que las distintas masas efectivamente ejercieran diferentes fuerzas en el dispositivo Phantom.

Adicionalmente, construí la escena del juego y los scripts relacionados a ésta incluyendo: El modelo base del cual se generan los objetos, la plataforma en la que deben ubicarse los objetos, el suelo que los sostiene, el script que hace que el suelo desaparezca después de cierto tiempo y el script que determina si el usuario perdió o ganó y que permite reiniciar el juego.



