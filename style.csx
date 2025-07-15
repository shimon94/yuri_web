
:root {
  --primary: #2d89ef;
  --accent: #f7c948;
  --bg: #f7fafc;
  --text: #222;
  --card: #fff;
  --radius: 16px;
}

* {
  box-sizing: border-box;
}

body {
  font-family: 'Segoe UI', Arial, sans-serif;
  background: var(--bg);
  color: var(--text);
  margin: 0;
  padding: 0;
}

header {
  background: var(--primary);
  color: #fff;
  padding: 2rem 1rem 1rem 1rem;
  text-align: center;
}

.logo {
  width: 64px;
  height: 64px;
  border-radius: 50%;
  margin-bottom: 1rem;
  object-fit: cover;
  background: #fff;
  padding: 4px;
}

.subtitle {
  margin-top: 0.5rem;
  font-size: 1.1rem;
  opacity: 0.9;
}

.stats {
  display: flex;
  flex-wrap: wrap;
  justify-content: center;
  gap: 1rem;
  margin: 2rem 0;
}

.stat {
  background: var(--card);
  border-radius: var(--radius);
  box-shadow: 0 2px 8px rgba(0,0,0,0.06);
  padding: 1.2rem 2rem;
  min-width: 120px;
  text-align: center;
}

.stat h2 {
  margin: 0;
  font-size: 2.2rem;
  color: var(--primary);
}

.stat p {
  margin: 0.5rem 0 0;
  font-size: 1rem;
  color: #555;
}

.images {
  margin: 2rem 0;
}

.images h2 {
  text-align: center;
  margin-bottom: 1rem;
}

.image-gallery {
  display: flex;
  flex-wrap: wrap;
  gap: 1rem;
  justify-content: center;
}

.image-gallery img {
  width: 100%;
  max-width: 320px;
  border-radius: var(--radius);
  box-shadow: 0 2px 8px rgba(0,0,0,0.09);
  object-fit: cover;
}

.details {
  max-width: 700px;
  margin: 2rem auto;
  background: var(--card);
  border-radius: var(--radius);
  padding: 2rem;
  box-shadow: 0 2px 12px rgba(0,0,0,0.07);
}

footer {
  text-align: center;
  padding: 1.2rem 0;
  background: #ececec;
  color: #666;
  margin-top: 2rem;
  font-size: 0.95rem;
}

@media (max-width: 600px) {
  .stats {
    flex-direction: column;
    gap: 0.5rem;
  }
  .stat {
    padding: 1rem;
  }
  .image-gallery {
    flex-direction: column;
    gap: 0.7rem;
  }
  .details {
    padding: 1rem;
  }
  header {
    padding: 1.2rem 0.5rem 0.5rem 0.5rem;
  }
}
