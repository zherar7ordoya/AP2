INCLUDE 'emu8086.inc'
ORG 100h

; H <-> L

MOV bh, 1
MOV bl, 0
MOV cx, 14  ; Es lo maximo posible para el rango

fibonacci:
CALL    print_num

MOV ah, 2
MOV dl, ' '
INT 21h

MOV al, bh
ADD bh, bl
MOV bl, al

MOV ah, 0

LOOP fibonacci

RET

DEFINE_PRINT_NUM        ; procedure that prints a signed number in AX register.

DEFINE_PRINT_NUM_UNS    ; required for print_num.

END