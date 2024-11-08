---
hide:
  - toc
---

<div align="center">
	<h1>The Reloaded MkDocs Theme</h1>
	<img src="../Images/Reloaded-Icon.png" width="150" align="center" />
	<br/> <br/>
    A Theme for MkDocs Material.
    <br/>
    That resembles the look of <i>Reloaded</i>.
</div>

## About

This it the NexusMods theme for Material-MkDocs, inspired by the look of [Reloaded-II](https://reloaded-project.github.io/Reloaded-II/).  

The overall wiki theme should look fairly close to the actual launcher appearance.  

## Setup From Scratch

- Add [this repository](https://github.com/Reloaded-Project/Reloaded.MkDocsMaterial.Themes.R2) as submodule to `docs/Reloaded`.
- Save the following configuration as `mkdocs.yml` in your repository root.

```yaml
site_name: Reloaded MkDocs Theme
site_url: https://github.com/Reloaded-Project/Reloaded.MkDocsMaterial.Themes.R2

repo_name: Reloaded-Project/Reloaded.MkDocsMaterial.Themes.R2
repo_url: https://github.com/Reloaded-Project/Reloaded.MkDocsMaterial.Themes.R2

extra:
  social:
    - icon: fontawesome/brands/github
      link: https://github.com/Reloaded-Project
    - icon: fontawesome/brands/twitter
      link: https://twitter.com/thesewer56?lang=en-GB

extra_css:
  - Reloaded/Stylesheets/extra.css

markdown_extensions:
  - admonition
  - tables
  - pymdownx.details
  - pymdownx.highlight
  - pymdownx.superfences:
      custom_fences:
        - name: mermaid
          class: mermaid
          format: !!python/name:pymdownx.superfences.fence_code_format
  - pymdownx.tasklist
  - def_list
  - meta
  - md_in_html
  - attr_list
  - footnotes
  - pymdownx.tabbed:
      alternate_style: true
  - pymdownx.emoji:
      emoji_index: !!python/name:materialx.emoji.twemoji
      emoji_generator: !!python/name:materialx.emoji.to_svg

theme:
  name: material
  palette:
    scheme: reloaded-slate
  features:
    - navigation.instant

plugins:
  - search

nav:
  - Home: index.md
```

- Add a GitHub Actions workload in `.github/workflows/DeployMkDocs.yml`.

```yaml
name: DeployMkDocs

# Controls when the action will run. 
on:
  # Triggers the workflow on push on the master branch
  push:
    branches: [ main ]

  # Allows you to run this workflow manually from the Actions tab
  workflow_dispatch:

# A workflow run is made up of one or more jobs that can run sequentially or in parallel
jobs:
  # This workflow contains a single job called "build"
  build:
    # The type of runner that the job will run on
    runs-on: ubuntu-latest

    # Steps represent a sequence of tasks that will be executed as part of the job
    steps:
      
      # Checks-out your repository under $GITHUB_WORKSPACE, so your job can access it
      - name: Checkout Branch
        uses: actions/checkout@v2
        with:
          submodules: recursive

      # Deploy MkDocs
      - name: Deploy MkDocs
        # You may pin to the exact commit or the version.
        # uses: mhausenblas/mkdocs-deploy-gh-pages@66340182cb2a1a63f8a3783e3e2146b7d151a0bb
        uses: mhausenblas/mkdocs-deploy-gh-pages@master
        env:
          GITHUB_TOKEN: ${{ secrets.GITHUB_TOKEN }}
          REQUIREMENTS: ./docs/requirements.txt
```

- Push to GitHub, this should produce a GitHub Pages site.  
- Go to `Settings -> Pages` in your repo and select `gh-pages` branch to enable GitHub pages. 

Your page should then be live.

!!! tip

    Refer to [Contributing](contributing.md#website-live-preview) for instructions on how to locally edit and modify the wiki.

!!! note

    For Reloaded3 theme use `reloaded3-slate` instead of `reloaded-slate`.

## Extra

!!! info

    Most documentation pages will also include additional plugins; some which are used in the pages here.  
    Here is a sample complete mkdocs.yml you can copy to your project for reference.  

## Technical Questions

If you have questions/bug reports/etc. feel free to [Open an Issue](https://github.com/Reloaded-Project/Reloaded.MkDocsMaterial.Themes.R2/issues/new).

Happy Documenting ❤️