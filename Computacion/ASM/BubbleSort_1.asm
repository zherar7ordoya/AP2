include 'emu8086.inc'
org 100h 

.data
array   db 4, 3, 2, 1, 9, 8, 7
count   dw 7

.code
MOV     cx, count      
DEC     cx               ; outer loop iteration count

explorar:                ; do {    // outer loop
MOV     bx, cx
MOV     si, 0 

comparar:
MOV     al, array[si]
MOV     dl, array[si+1]
CMP     al, dl

JNC     continuar           ; Short Jump if Carry flag is set to 0. 

MOV     array[si], dl
MOV     array[si+1], al

continuar: 
INC     si
DEC     bx                  ; Incide en los flags (al llegar a 0, se cumple la condición)
JNZ     comparar            ; Short Jump if Not Zero (not equal).

LOOP    explorar       ; } while(--cx);

; MOSTRAR EN CONSOLA
MOV     cx, 7
MOV     si, 0

imprimir:
MOV     al, array[si]  
ADD     al, 30h
MOV     ah, 0eh
INT     10h
; INT 10h / AH = 0Eh: this functions displays a character on the screen. input: AL = character to write.
MOV     ah, 2
MOV     dl, ' '
INT     21h
; INT 21h / AH=2: write character to standard output. Entry: DL = character to write, after execution AL = DL.
INC     si
LOOP    imprimir

RET