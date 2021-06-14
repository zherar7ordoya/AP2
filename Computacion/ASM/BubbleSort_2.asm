INCLUDE 'emu8086.inc'   ; [1]
ORG 100h

; VARIABLES
;serie DB 15, 12, 8, 5, 37, 255, 2, 0
          
; PROGRAMA

MOV     cx, 7           ;
MOV     si, 0           ;
MOV     di, 0           ;

ciclo1:
PUSH    cx              ; poner en la pila el valor de cx
LEA     si, serie       ; pasar la direccion efectiva del arreglo a SI...
MOV     di, si          ; ...y luego pasarla a DI

ciclo2:
INC     di              ; incrementar DI para poder comparar con la siguiente posición
MOV     al, [si]        ; pasar el valor que se encuentra en SI a AL
CMP     al, [di]        ; comparar con el valor en DI

JA      intercambio     ; si es mayor, ir a etiqueta
JB      continuar       ; si es menor, ir a etiqueta

intercambio:
MOV     ah, [di]        ; mueve el valor de DI a AH
MOV     [di], al        ; mueve el valor de AL a DI
MOV     [si], ah        ; mueve el valor de AH a SI
;LOOP    intercambio

continuar:
INC     si
LOOP    ciclo2
POP     cx
LOOP    ciclo1

RET

serie DB 15, 12, 8, 5, 37, 255, 2, 0

END