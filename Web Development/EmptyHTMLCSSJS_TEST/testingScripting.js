        // Get the elements
        const imageUpload = document.getElementById('imageUpload');
        const imageDisplay = document.getElementById('imageDisplay');
        const gridDisplay = document.querySelector('.grid-display');
        
        imageUpload.addEventListener('change', function() {
            const images = Array.from(this.files); // Convert FileList to an array
        
            images.forEach(image => {
                const reader = new FileReader();
                
                reader.addEventListener('load', function() {
                    const imgElement = document.createElement('img');
                    imgElement.src = this.result;
        
                    const gridItem = document.createElement('div');
                    gridItem.classList.add('grid-item');
                    gridItem.appendChild(imgElement);
        
                    gridDisplay.appendChild(gridItem);
                });
        
                reader.readAsDataURL(image);
            });
        });
        