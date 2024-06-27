export function getFullYear(){
    var date = new Date();
    var CurrentYear = date.getFullYear();
    return CurrentYear;
}

export function getFooterCopy(isIndex){
    if (typeof isIndex === 'boolean'){
        return 'Holberton School';
    }
    else {
        return 'Holberton School main dashboard';
    }
}