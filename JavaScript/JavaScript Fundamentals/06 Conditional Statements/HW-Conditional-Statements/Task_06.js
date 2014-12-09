// Write a script that enters the coefficients a, b and c of a quadratic equation a*x2 + b*x + c = 0

var a = 0;
var b = 3;
var c = 5;
var discriminant, x1, x2;

discriminant = (b * b) - (4 * a * c);

if (discriminant > 0) {
    x1 = (-b + Math.sqrt(discriminant)) / (2 * a);
    x2 = (-b - Math.sqrt(discriminant)) / (2 * a);

    console.log('x1 = ' + x1);
    console.log('x2 = ' + x2);
}
else if (discriminant === 0) {
    x1 = (-b) / (2 * a);
    console.log('x1 = x2 = ' + x1);
}
else {
    console.log('There are no real roots. There are two complex roots.');
}