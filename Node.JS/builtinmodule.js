var nodemailer = require('nodemailer');

    var transporter = nodemailer.createTransport(
        {
            service: 'hotmail',
            auth: {
                user: 'abimannanabibalor@gmail.com',
                pass: 'Abimannan@123'
            }
        }
    );

    var mailOptions =
    {
        from: 'abimannanabibalor@gmail.com',
        to: 'aabimannan19bm@srishakthi.ac.in',        //add more comma separated receipients 
        subject: 'Sending Email using Node.js',
        text: 'That was easy!'                   // html: '<h1>Welcome</h1><p>That was easy!</p>'
    };

    transporter.sendMail(mailOptions, function (error, info)
    {
        if (error) {
            console.log(error);
        } else {
            console.log('Email sent: ' + info.response);
        }
    });