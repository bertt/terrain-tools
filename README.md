# terrain-tools

Merges 2 quantized mesh terrain tiles sets (layer.json files) into one.


## Usage

Sync the two tilesset using rsync

```
$ sync -r ../nantes/tiles/ ../lyon/tiles/ tiles
```

Merge the two layer.json files into one using this tool. For each level in the available levels, the tool will merge the 
compare the startX, startY, endX, endY values.
