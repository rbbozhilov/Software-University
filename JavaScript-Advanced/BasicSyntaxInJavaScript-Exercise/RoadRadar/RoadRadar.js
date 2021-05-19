function Solution(currentSpeed,currentArea) {

    let allowSpeed = 0;

    switch(currentArea) {

        case 'motorway': allowSpeed = 130; break;
        case 'interstate': allowSpeed = 90; break;
        case 'city': allowSpeed = 50; break;
        case 'residential': allowSpeed = 20; break;
    }

    if (currentSpeed<=allowSpeed) {
        console.log('Driving %s km/h in a %s zone',currentSpeed,allowSpeed);
    } else {
        
        let currentSpeedDifference = currentSpeed - allowSpeed;
        let status;
       

        if (currentSpeedDifference >= 1 && currentSpeedDifference<=20) {
            status = 'speeding';
        } else if(currentSpeedDifference>20 && currentSpeedDifference<=40) {
            status = 'excessive speeding ';
        } else {
            status = 'reckless driving';
        }
        console.log('The speed is %s km/h faster than the allowed speed of %s - %s',currentSpeedDifference,allowSpeed,status);


    }


}




Solution(21, 'residential');