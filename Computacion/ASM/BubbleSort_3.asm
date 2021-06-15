INCLUDE 'emu8086.inc'   ; [1]
ORG 100h

; VARIABLES
;serie DB 15, 12, 8, 5, 37, 255, 2, 0
          
; PROGRAMA

<<<<<<< HEAD
MOV     cx, 7           ; asignar a CX un 7 (por los 8 elementos del array)

ciclo1: ; ---------------------------------------------------------------------
PUSH    cx              ; poner en la pila el valor de CX (un 7)
MOV     si, 0           ; resetear
MOV     di, 0           ; resetear

ciclo2: ; ---------------------------------------------------------------------
INC     di              ; incrementar DI para comparar la siguiente posición
MOV     al, serie[si]   ; pasar el valor que se encuentra en SI a AL
CMP     al, serie[di]   ; comparar con el valor en DI

JA      intercambio     ; (JUMP ABOVE) si el primer operador es mayor, ir a...
JB      continuar       ; (JUMP BELOW) si el primer operador es menor, ir a...

intercambio:
MOV     ah, [di]        ; AH = 12
MOV     [di], al        ; DI = 15 => (escribiendo en serie)
MOV     [si], ah        ; SI = 12 => (escribiendo en serie)

continuar:
INC     si              ; ...ahora apunta a 12
LOOP    ciclo2          ; decrementa CX (=6), si CX <> 0, salta a etiqueta.
POP     cx              ; recompone CX=7
LOOP    ciclo1          ; decrementa CX(=6)
=======
MOV     cx, 7           ;

ciclo1:
PUSH    cx              ; poner en la pila el valor de cx
; LEA     si, serie       ; pasar la direccion efectiva del arreglo a SI...
; MOV     di, si          ; ...y luego pasarla a DI
MOV     si, 0           ;
MOV     di, 0           ;

ciclo2:
INC     di              ; incrementar DI para poder comparar con la siguiente posición
MOV     al, serie[si]        ; pasar el valor que se encuentra en SI a AL
CMP     al, serie[di]        ; comparar con el valor en DI

JA      intercambio     ; si es mayor, ir a etiqueta
JB      continuar       ; si es menor, ir a etiqueta

intercambio:
MOV     ah, serie[di]        ; mueve el valor de DI a AH
MOV     serie[di], al        ; mueve el valor de AL a DI
MOV     serie[si], ah        ; mueve el valor de AH a SI
;LOOP    intercambio

continuar:
INC     si
LOOP    ciclo2
POP     cx
LOOP    ciclo1
>>>>>>> 8829a11a87e22b4b396478f80b45565bf07cc1ac

RET

serie DB 15, 12, 8, 5, 37, 255, 2, 0

END