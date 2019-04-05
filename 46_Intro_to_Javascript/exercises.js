function sumDouble(param1, param2) {
    if (param1 != param2) {
        return param1 + param2;
    } else {
        return (param1 + param2) * 2;
    }
}

function hasTeen(param1, param2, param3) {

    const param1IsTeen = (param1 >= 13 && param1 <= 19);
    const param2IsTeen = (param2 >= 13 && param2 <= 19);
    const param3IsTeen = (param3 >= 13 && param3 <= 19);

    if (param1IsTeen) {
        return true;
    } else if (param2IsTeen) {
        return true;
    } else if (param3IsTeen) {
        return true;
    } else {
        return false;
    }
}

function lastDigit(param1, param2) {

    const param1End = param1 % 10;
    const param2End = param2 % 10;

    if (param1End === param2End) {
        return true;
    } else {
        return false;
    }
}

function seeColor(param1) {

    if (param1.startsWith("red")) {
        return "red";
    } else if (param1.startsWith("blue")) {
        return "blue";
    } else {
        return "";
    }
}

function oddOnly(param1) {

    return param1.filter(num => num % 2 == 1);

}

function frontAgain(param1) {

    start = param1.substring(0, 2);
    end = param1.substring(param1.length - 2);

    if (start == end) {
        return true;
    } else {
        return false;
    }
}

function cigarParty(param1, param2) {
    return param1 >= 40 && ((param1 <= 60 && param2 == false) || (param2 == true));
}

function fizzBuzz(param1) {
    answer = "";

    if (param1 % 3 == 0 && param1 % 5 == 0) {
        answer = "FizzBuzz";
    } else if (param1 % 5 == 0) {
        answer = "Buzz";
    } else if (param1 % 3 == 0) {
        answer = "Fizz";
    } else {
        answer = param1;
    }

    return answer;
}

function filterEvens(param1) {
    return param1.filter(nums => nums % 2 == 0);
}

function filterBigNumbers(param1) {
    return param1.filter(nums => nums >= 100);
}

function filterMultiplesOfX(param1, param2) {
    return param1.filter(nums => nums % param2 == 0);
}

function createObject() {
    const person = {
    firstName: "Warren",
    lastName: "Stowe",
    age: 34
    }
    
    return person;
};