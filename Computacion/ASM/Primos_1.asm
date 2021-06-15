TITLE NUMEROS_PRIMOS

DATOS SEGMENT
; DECLARAR VARIABLES AQUI.-----------------------------------------------------
    NUMEROS DB 2, 4, 7, 44, 43, 18, 53, 22, 61, 66, 71, 1
    PRIMOS DB 12 DUP(?)
    NOPRIMOS DB 12 DUP(?)

; -----------------------------------------------------------------------------
DATOS ENDS    


PILA SEGMENT
    DB 64 DUP(0)
PILA ENDS    


CODIGO SEGMENT
    INICIO PROC FAR ;  Si el procedimiento es el principal de un programa, ha de utilizarse el atributo FAR
        ASSUME DS: DATOS, CS: CODIGO, SS: PILA
        PUSH DS
        MOV AX, 0
        PUSH AX
        
        MOV AX, DATOS
        MOV DS, AX
        MOV ES, AX
        
        ; CODIGO DE NUESTRO PROGRAMA AQUI.-------------------------------------
        MOV SI, 0
        MOV DI, 0
        MOV AX, 0
        
        CICLO:
        CMP SI, 12
        JE EXIT
        
        MOV BL, 1
        MOV AL, NUMEROS[SI]
        CMP AL, 2
        
        JE PAR_PRIMO
        JG PRIMO
        JL NO_PRIMO
        
        PRIMO:
        MOV AX, 0
        MOV AL, NUMEROS[SI]
        INC BL
        DIV BL
        CMP AH, 0
        
        JE NO_PRIMO
        JG CORROBORA
        
        CORROBORA:
        MOV AX, 0
        MOV AL, NUMEROS[SI]
        INC BL
        DIV BL
        CMP AH, 0
        
        JG CORROBORA
        JE GUARDARPRIMO
        
        GUARDARPRIMO:
        MOV AL, NUMEROS[SI]
        MOV PRIMOS[DI], AL
        INC SI
        INC DI
        JMP CICLO



        ; ---------------------------------------------------------------------

        EXIT:
        RET
    INICIO ENDP
CODIGO ENDS

END INICIO