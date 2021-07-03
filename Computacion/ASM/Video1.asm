.model small
.data
    saludo db "Welcome to the Jaguar House", "$"
.code
programa:
    MOV ax, seg saludo
    MOV ds, ax
    MOV ah, 09h
    LEA dx, saludo
    INT 21h
    
    MOV ax,4c00h
    int 21h
end programa