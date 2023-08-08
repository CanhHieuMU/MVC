// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
// Check password
const psw = document.getElementById("passwords");
const rppsw = document.getElementById("passwords-repeat")
let passwordsMatch = false;

if (psw.value == passwords-repeat.value) {
    passwordsMatch = true;
    
} else {
    passwordsMatch = false;
    alert("mat khau khong trung khop")
    return;
}
