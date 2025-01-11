# Challenge-Submission
New gov.uk
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>MyGov Services</title>
    <style>
        /* Base styles */
        body {
            margin: 0;
            font-family: "GDS Transport", arial, sans-serif;
            color: #0b0c0c;
            line-height: 1.5;
            transition: all 0.3s ease;
            min-height: 100vh;
            display: flex;
            flex-direction: column;
            background: #f3f2f1;
        }

        .header {
            background: #0b0c0c;
            padding: 15px 0;
            color: white;
            border-bottom: 10px solid #1d70b8;
            width: 100%;
        }

        .header-content {
            max-width: 1600px; /* Increased from 1200px */
            margin: 0 auto;
            padding: 0 40px;
            display: flex;
            justify-content: space-between;
            align-items: center;
        }

        .main-content {
            flex: 1;
            max-width: 1600px; /* Increased from 1200px */
            margin: 30px auto;
            padding: 40px;
            width: 95%; /* Using percentage for better space usage */
            box-sizing: border-box;
            background: white;
        }

        .welcome-section {
            margin-bottom: 40px;
        }

        .service-grid {
            display: grid;
            grid-template-columns: repeat(auto-fill, minmax(400px, 1fr)); /* Increased card size */
            gap: 30px;
            margin-top: 30px;
        }

        .service-section {
            background: #f8f8f8;
            border-left: 4px solid #1d70b8;
            padding: 30px; /* Increased padding */
            height: 100%;
            box-sizing: border-box;
            display: flex;
            flex-direction: column;
            justify-content: space-between;
        }

        .service-header {
            display: flex;
            align-items: center;
            margin-bottom: 20px;
        }

        .service-icon {
            font-size: 32px; /* Increased size */
            margin-right: 15px;
        }

        .service-section h2 {
            font-size: 24px; /* Increased size */
            margin: 0;
        }

        .service-section p {
            font-size: 18px; /* Increased size */
            margin: 15px 0;
            flex-grow: 1;
        }

        .age-selector {
            position: fixed;
            top: 100px;
            right: 40px;
            background: white;
            padding: 25px;
            border: 5px solid #1d70b8;
            width: 250px; /* Increased width */
            z-index: 100;
            box-shadow: 0 4px 15px rgba(0,0,0,0.1);
        }

        /* Service detail page improvements */
        .service-detail-grid {
            display: grid;
            grid-template-columns: 2fr 1fr;
            gap: 40px;
            margin-top: 30px;
        }

        .service-summary {
            background: #f8f8f8;
            padding: 35px;
            margin-top: 20px;
            border-left: 4px solid #1d70b8;
        }

        .steps-list {
            padding-left: 25px;
            margin-top: 25px;
        }

        .steps-list li {
            margin-bottom: 20px;
            font-size: 18px;
        }

        /* Sign in page improvements */
        .signin-container {
            max-width: 800px;
            margin: 0 auto;
        }

        .form-group {
            margin-bottom: 35px;
        }

        .form-label {
            display: block;
            font-weight: bold;
            margin-bottom: 15px;
            font-size: 19px;
        }

        .form-input {
            width: 100%;
            padding: 15px;
            border: 2px solid #0b0c0c;
            font-size: 18px;
        }

        .button {
            background: #00703c;
            color: white;
            padding: 15px 30px;
            border: none;
            cursor: pointer;
            font-size: 19px;
            text-decoration: none;
            display: inline-block;
            margin-top: 15px;
            font-weight: bold;
            box-shadow: 0 2px 0 #002d18;
            min-width: 200px;
            text-align: center;
        }

        .button:hover {
            background: #005a30;
        }

        .page {
            display: none;
            width: 100%;
        }

        .page.active {
            display: block;
        }

        h1 {
            font-size: 48px;
            line-height: 1.2;
            margin-bottom: 30px;
        }

        .warning-text {
            background: #fff4bd;
            padding: 25px;
            border-left: 4px solid #ffd700;
            margin: 25px 0;
            font-size: 18px;
        }

        /* Responsive improvements */
        @media (max-width: 1200px) {
            .service-grid {
                grid-template-columns: repeat(auto-fill, minmax(350px, 1fr));
            }

            .service-detail-grid {
                grid-template-columns: 1fr;
            }
        }

        @media (max-width: 768px) {
            .main-content {
                padding: 20px;
                width: 100%;
            }

            .service-grid {
                grid-template-columns: 1fr;
            }

            .age-selector {
                position: static;
                width: auto;
                margin: 20px 0;
            }

            h1 {
                font-size: 36px;
            }
        }
    </style>
</head>
<body>
    <!-- Rest of the HTML remains the same -->
    <header class="header">
        <div class="header-content">
            <div onclick="showPage('home')" style="cursor: pointer;">
                <span class="crown">👑</span>
                <span>MyGov</span>
            </div>
            <a href="#" class="sign-in" onclick="showPage('signin')">Sign in</a>
        </div>
    </header>

    <!-- Home Page -->
    <div id="home" class="page active">
        <main class="main-content">
            <div class="welcome-section">
                <h1>Welcome to MyGov Services</h1>
                <p style="font-size: 20px;">Access government services and information tailored to you</p>
            </div>

            <div class="age-selector" id="ageSelector">
                <h2>Select your age</h2>
                <input type="range" id="age-slider" min="0" max="100" value="25">
                <p>Age: <span id="age-value">25</span></p>
                <button class="button" id="confirmAgeButton">Confirm age</button>
            </div>

            <div class="service-grid" id="services-container"></div>
        </main>
    </div>

    <!-- Sign In Page -->
    <div id="signin" class="page">
        <main class="main-content">
            <div class="signin-container">
                <a href="#" class="back-link" onclick="showPage('home')">Back to home</a>
                <h1>Sign in to MyGov</h1>

                <div class="error-summary" id="error-summary">
                    <h2>There is a problem</h2>
                    <ul id="error-list"></ul>
                </div>

                <form onsubmit="handleSignIn(event)">
                    <div class="form-group">
                        <label class="form-label" for="email">Email address</label>
                        <input type="email" id="email" class="form-input" required>
                    </div>

                    <div class="form-group">
                        <label class="form-label" for="password">Password</label>
                        <input type="password" id="password" class="form-input" required>
                    </div>

                    <button type="submit" class="button">Sign in</button>
                </form>
            </div>
        </main>
    </div>

    <!-- Service Detail Pages -->
    <div id="service-detail" class="page">
        <main class="main-content">
            <a href="#" class="back-link" onclick="showPage('home')">Back to services</a>
            <h1 id="service-title"></h1>

            <div class="service-detail-grid">
                <div>
                    <div class="service-summary">
                        <h2>What you'll need</h2>
                        <ul class="steps-list" id="service-requirements"></ul>
                    </div>

                    <div class="warning-text">
                        <p>This service typically takes 20 minutes to complete.</p>
                    </div>

                    <button class="button" onclick="handleServiceStart()">Start now</button>
                </div>

                <div class="service-summary">
                    <h2>Help and support</h2>
                    <p>If you need help with this service, contact:</p>
                    <ul class="steps-list">
                        <li>Email: support@mygov.com</li>
                        <li>Phone: 0300 123 4567</li>
                        <li>Monday to Friday, 9am to 5pm</li>
                    </ul>
                </div>
            </div>
        </main>
    </div>

    <!-- Same JavaScript as before -->
    <script>
        // Previous JavaScript code remains unchanged
        const services = [
            {
                title: "Education Services",
                icon: "🎓",
                description: "Access school and education-related services",
                minAge: 5,
                maxAge: 25,
                requirements: [
                    "Proof of identity",
                    "School or institution details",
                    "Previous education records",
                    "Contact information"
                ]
            },
            {
                title: "Driving License",
                icon: "🚗",
                description: "Apply for or renew your driving license",
                minAge: 17,
                maxAge: 100,
                requirements: [
                    "Valid ID or passport",
                    "Current address proof",
                    "Medical information",
                    "Payment method"
                ]
            },
            {
                title: "Pension Services",
                icon: "👴",
                description: "Access pension and retirement services",
                minAge: 60,
                maxAge: 100,
                requirements: [
                    "National Insurance number",
                    "Bank account details",
                    "Employment history",
                    "Pension scheme information"
                ]
            },
            {
                title: "Child Benefits",
                icon: "👶",
                description: "Information about child benefits and support",
                minAge: 16,
                maxAge: 65,
                requirements: [
                    "Child's birth certificate",
                    "Proof of residence",
                    "Income details",
                    "Bank account information"
                ]
            },
            {
                title: "Employment Support",
                icon: "💼",
                description: "Find job opportunities and career advice",
                minAge: 16,
                maxAge: 65,
                requirements: [
                    "CV or resume",
                    "Work history",
                    "Qualifications",
                    "Right to work documents"
                ]
            }
        ];

        function showPage(pageId, serviceData = null) {
            document.querySelectorAll('.page').forEach(page => {
                page.classList.remove('active');
            });
            const page = document.getElementById(pageId);
            page.classList.add('active');

            if (pageId === 'service-detail' && serviceData) {
                document.getElementById('service-title').textContent = serviceData.title;
                const requirementsList = document.getElementById('service-requirements');
                requirementsList.innerHTML = '';
                serviceData.requirements.forEach(req => {
                    const li = document.createElement('li');
                    li.textContent = req;
                    requirementsList.appendChild(li);
                });
            }
        }

        function updateServices(age) {
            const container = document.getElementById('services-container');
            container.innerHTML = '';

            services.forEach(service => {
                if (age >= service.minAge && age <= service.maxAge) {
                    const serviceElement = document.createElement('div');
                    serviceElement.className = 'service-section';
                    serviceElement.innerHTML = `
                        <div class="service-header">
                            <span class="service-icon">${service.icon}</span>
                            <h2>${service.title}</h2>
                        </div>
                        <p>${service.description}</p>
                        <a href="#" class="button" onclick="showPage('service-detail', ${JSON.stringify(service)})">Start now</a>
                    `;
                    container.appendChild(serviceElement);
                }
            });
        }

        // Initialize services
        updateServices(25);

        const ageSlider = document.getElementById('age-slider');
        const ageValue = document.getElementById('age-value');

        ageSlider.addEventListener('input', (e) => {
            const age = e.target.value;
            ageValue.textContent = age;
            updateServices(parseInt(age));
        });

        document.getElementById('confirmAgeButton').addEventListener('click', () => {
            const ageSelector = document.getElementById('ageSelector');
            ageSelector.style.display = 'none';
        });

        function handleSignIn(event) {
            event.preventDefault();
            const errorSummary = document.getElementById('error-summary');
            const errorList = document.getElementById('error-list');

            const email = document.getElementById('email').value;
            const password = document.getElementById('password').value;

            if (!email || !password) {
                errorSummary.style.display = 'block';
                errorList.innerHTML = '<li>Please fill in all required fields</li>';
            } else {
                alert('Sign in functionality would be implemented here');
            }
        }

        function handleServiceStart() {
            alert('Service application process would start here');
        }
    </script>
</body>
</html>
