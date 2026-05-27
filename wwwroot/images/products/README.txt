PRODUCT IMAGES FOLDER
=====================

This folder contains default product images for each pili flavor category.
The application automatically uses these images when no custom image is uploaded for a product.

REQUIRED IMAGE FILES:
====================

1. honey-glazed-crispy-pili.jpg
   - For: Honey Glazed Crispy Pili category
   - Image name on product: "HONEY GLAZED CRISPY PILI"

2. salted-caramel-pili.jpg
   - For: Salted Caramel Crispy Pili category
   - Image name on product: "Salted Caramel Pili"

3. salted-pili.jpg
   - For: Salted Pili category
   - Image name on product: "Greaseless Salted Pili with Garlic" (or any Salted variant)

4. roasted-pili.jpg
   - For: Roasted Pili category
   - Image name on product: "Roasted Pili"

5. sweet-chilli-pili.jpg
   - For: Sweet Chilli Pili category
   - Image name on product: "Sweet Chilli Pili"

Optional:
---------
6. default-pili.jpg
   - Fallback image if category mapping not found
   - Recommended: Generic pili product image

HOW IT WORKS:
=============

1. Place product images in this folder with the exact filenames listed above
2. Rename each image according to its category mapping
3. When a product is created/edited without a custom image, 
   the system will automatically display the corresponding default image
4. Users can still upload custom images for individual products
5. Custom uploads will override the default category image

IMAGE RECOMMENDATIONS:
======================

- Format: JPG or PNG
- Resolution: At least 300x300 pixels (recommended 400x400 or larger)
- File size: Keep under 500KB for optimal performance
- Aspect ratio: Square (1:1) works best in the UI
- Quality: High quality photos of the actual products

EXAMPLE WORKFLOW:
=================

1. When you create a product with category "Honey Glazed Crispy Pili"
2. System checks if honey-glazed-crispy-pili.jpg exists
3. If it does, that image is displayed automatically
4. If you upload a custom image, it takes priority and is used instead
5. The default image serves as a professional placeholder

NOTES:
======

- Image file names are case-sensitive on Linux/Mac servers
- Use lowercase with hyphens (no spaces)
- Ensure all required images are present for best results
- You can update images anytime - just replace the file in this folder
