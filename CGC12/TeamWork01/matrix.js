function IsValidNumber(num){
    num = parseInt(num);
    return !isNaN(num) && Number.isInteger(num) && num >= 10 && num <= 20;
}

function GenerateMatrix(row, col){
    let matrix = new Array(row);
    for(let i=0; i< row; i++){
        let arr = new Array(col);
        for(let j = 0; j< col; j++){
            arr[j] = Math.floor(Math.random() * 191 + 10);
        }
        matrix[i] = arr;
    }
    return matrix;
}

function ShowMatrix(row, col, matrix){
    let str =""
    for(let i=0; i< row; i++){
        str = str + "<tr>";
        for(let j = 0; j< col; j++){
            str = str + "<td>" + matrix[i][j] + "</td>";
        }
        str = str + "</tr>";
    }
    return str;
}

function MaxValue(row, col, matrix){
    let max = matrix[0][0];
    for(let i=1; i< row; i++){
        for(let j = 1; j< col; j++){
            if(max < matrix[i][j])
                max = matrix[i][j];
        }
    }
    return max;
}

function MimValue(row, col, matrix){
    let min = matrix[0][0];
    for(let i=1; i< row; i++){
        for(let j = 1; j< col; j++){
            if(min > matrix[i][j])
                min = matrix[i][j];
        }
    }
    return min;
}

function TotalOdd(row, col, matrix){
    let total = 0;
    for(let i=1; i< row; i++){
        for(let j = 1; j< col; j++){
            if(matrix[i][j] % 2 != 0)
                total = total + 1;
        }
    }
    return total;
}

function IsPrime(num){
    for(let i = 2; i <= Math.sqrt(num); i++){
        if(num % i == 0){
            return false;
        }
    }
    return true;
}

function TotalPrime(row, col, matrix){
    let total = 0;
    for(let i=1; i< row; i++){
        for(let j = 1; j< col; j++){
            if(IsPrime(matrix[i][j]))
                total = total + 1;
        }
    }
    return total;
}

function Sort(row, col, matrix){

}

function Main(){
    let row = document.getElementById("rowNum").value;
    let col = document.getElementById("colNum").value;
    let rowMsg = document.getElementById("spRowMessage");
    let colMsg = document.getElementById("spColMessage");
    let validRow = IsValidNumber(row);
    let validCol = IsValidNumber(col);
    if(!validRow){
        rowMsg.innerText = "Invalid row value";
    }
    if(!validCol){
        colMsg.innerText = "Invalid col value";
    }

    if(validRow && validCol){
        let matrix = GenerateMatrix(row, col);
        let mData = ShowMatrix(row, col, matrix);
        document.getElementById("tbMatrix1").innerHTML = mData;
        document.getElementById("tbMatrix2").innerHTML = mData;
        document.getElementById("maxValue").innerHTML = MaxValue(row, col, matrix);
        document.getElementById("minValue").innerHTML = MimValue(row, col, matrix);
        document.getElementById("totalOdd").innerHTML = TotalOdd(row, col, matrix);
        document.getElementById("totalPrime").innerHTML = TotalPrime(row, col, matrix);
    }
}