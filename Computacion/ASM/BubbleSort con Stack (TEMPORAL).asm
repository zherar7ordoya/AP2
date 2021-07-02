INCLUDE 'emu8086.inc'   ; [1]
ORG 100h

; VARIABLES
;serie DB 15, 12, 8, 5, 37, 255, 2, 0
          
; PROGRAMA

MOV     cx, 7           ;
MOV     si, 0           ;
MOV     di, 0           ;
; Se inicia con un contador en 7 (para 8 objetos del array)
ciclo1: ; ---------------------------------------------------------------------
PUSH    cx              ; poner en la pila el valor de CX (un 7)
LEA     si, serie       ; pasar la direccion efectiva del arreglo a SI...
MOV     di, si          ; ...y luego pasarla a DI
; PRUEBA DE ESCRITORIO
;       CX = 7
;       SI = serie (direcci�n) => Es un puntero: apunta a 15
;       DI = serie (direcci�n) => Es un puntero: apunta a 15

ciclo2: ; ---------------------------------------------------------------------
INC     di              ; incrementar DI para poder comparar con la siguiente posici�n
MOV     al, [si]        ; pasar el valor que se encuentra en SI a AL
CMP     al, [di]        ; comparar con el valor en DI
; PRUEBA DE ESCRITORIO
;       CX = 7
;       SI = serie (direcci�n)     => Es un puntero: * a�n apunta a 15
;       DI = serie (direcci�n) + 1 => Es un puntero: ahora apunta a 12
;       AL = SI (direcci�n de la serie)
;       CMP = AL - DI [direcci�n - (direcci�n + 1)]: 15 comparado 12

JA      intercambio     ; (JUMP ABOVE) si el primer operador es mayor, ir a...
JB      continuar       ; (JUMP BELOW) si el primer operador es menor, ir a...
; PRUEBA DE ESCRITORIO
;       CX = 7
;       SI = 15
;       DI = 12
;       AL = 15
;       (contin�a en intercambio)

; SI EL 1ER OPERADOR FUE MENOR, ESTA SECCI�N ES OMITIDA.-----------------------
intercambio:
MOV     ah, [di]        ; AH = 12
MOV     [di], al        ; DI = 15 => (escribiendo en serie)
MOV     [si], ah        ; SI = 12 => (escribiendo en serie)
; -----------------------------------------------------------------------------
; (contin�a PRUEBA DE ESCRITORIO):
continuar:
INC     si              ; ...ahora apunta a 12
LOOP    ciclo2          ; decrementa CX (=6), si CX <> 0, salta a etiqueta.
POP     cx              ; recompone CX=7
LOOP    ciclo1          ; decrementa CX(=6)

RET

serie DB 15, 12, 8, 5, 37, 255, 2, 0

END